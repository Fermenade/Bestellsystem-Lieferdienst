using Client_Server_Code_Library;
using System.Reflection;

namespace Bestellsystem_Lieferdienst_Server.DAL
{
    public class SqlCommand
    {
        //Trust me, this class will improve our all life :thumbsup: 
        public string SqlStatement { get; private set; } = string.Empty;
        public (string, object)[]? Parameters { get; private set; } = [];

        //Generated 1/2
        public SqlCommand Insert<T>(string table, T data, string[] returnColumns = null)
        {
            // Get properties of the type T that are not marked with IgnoreInsertAttribute
            var properties = typeof(T).GetFields()
                .Skip(1) //This is to skip the id. TODO: check if n:m insert break here (they'll prob break)
                .Where(p => !Attribute.IsDefined(p, typeof(IgnoreInsertAttribute)));

            // Get the column names from the properties
            var columnNames = properties.Select(p => p.Name).ToList();

            // Build the insert statement with OUTPUT clause
            SqlStatement = BuildInsertStatement(table, columnNames, returnColumns);

            // Convert properties to parameters
            Parameters = ConvertToParameters(properties, data);

            return this;
        }

        public SqlCommand Update<T>(string table, T data)
        {
            var properties = typeof(T).GetFields();
            var columnNames = properties.Select(p => p.Name);

            SqlStatement = BuildUpdateStatement(table, columnNames);
            Parameters = ConvertToParameters(properties, data);

            return this;
        }
        //1/2 Generated
        private string GetUniqueParameterName(string baseName)
        {
            string uniqueName = baseName;
            int counter = 1;

            while (Parameters.Any(name => name.Item1 == uniqueName))
            {
                uniqueName = $"{baseName}_{counter++}";
            }
            return uniqueName;
        }

        //1/2 Generated
        public SqlCommand SelectColumnsByJoin(
            string returnTable,
            string joinTable,
            IReadOnlyList<string> columns,
            (string, object)[]? joinIdentifier,
            (string, object)[]? identifier,
            IReadOnlyList<string>? groupBy = null)
        {
            var selectedColumns = string.Join(", ", columns.Select(FormatIdentifier));

            string joinCondition = string.Join(" AND ", joinIdentifier.Select(VARIABLE => 
                    {
                    string uniqueName = GetUniqueParameterName(VARIABLE.Item1);
                    return $"{FormatIdentifier(uniqueName)} = @{uniqueName}";
                    }
                    )
            );

            string whereCondition = string.Join(" AND ", identifier.Select(VARIABLE =>
                    {
                        string uniqueName = GetUniqueParameterName(VARIABLE.Item1);
                        return $"{FormatIdentifier(uniqueName)} = @{uniqueName}";
                    }
                )
            );

            // Build GROUP BY condition (if provided)
            string groupByClause = groupBy != null && groupBy.Count > 0
                ? "GROUP BY " + string.Join(", ", groupBy.Select(FormatIdentifier))
                : string.Empty; // no GROUP BY clause if null or empty

            // Final SQL Statement
            SqlStatement = $"SELECT {selectedColumns} FROM {FormatIdentifier(returnTable)} " +
                $"JOIN {FormatIdentifier(joinTable)} ON {joinCondition} " +
            $"{whereCondition} {groupByClause}";

            Parameters = (joinIdentifier ?? []).Concat(identifier ?? []).ToArray();

            return this;
        }

        public SqlCommand SelectAll(string table)
        {
            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)}";
            return this;
        }

        public SqlCommand SelectByNonPredefined(string table, (string, object)[] identifier)
        {
            var conditions = string.Join(" AND ", identifier.Select(i => $"{FormatIdentifier(i.Item1)} = @{i.Item1}"));

            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)} WHERE {conditions}";
            Parameters = identifier;

            return this;
        }

        public SqlCommand SelectById(string table, int id)
        {
            var idParam = CreateIdParameter(table, id);
            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)} WHERE {FormatIdentifier(table)}Id = @{table}Id";
            Parameters = idParam;

            return this;
        }

        public SqlCommand SelectColumnsById(string table, IReadOnlyList<string> columns, int id)
        {
            var selectedColumns = string.Join(", ", columns.Select(FormatIdentifier));
            SqlStatement = $"SELECT {selectedColumns} FROM {FormatIdentifier(table)} WHERE {FormatIdentifier(table)}Id = @{table}Id";
            Parameters = CreateIdParameter(table, id);

            return this;
        }

        public SqlCommand SelectColumns(string table, IReadOnlyList<string> columns)
        {
            var selectedColumns = string.Join(", ", columns.Select(FormatIdentifier));
            SqlStatement = $"SELECT {selectedColumns} FROM {FormatIdentifier(table)}";

            return this;
        }

        public SqlCommand DeleteById(string table, int id)
        {
            SqlStatement = $"DELETE FROM {FormatIdentifier(table)} WHERE {FormatIdentifier(table)}Id = @{table}Id";
            Parameters = CreateIdParameter(table, id);

            return this;
        }

        private static (string, object)[] CreateIdParameter(string table, int id) =>
            [($"@{table}Id", id)];

        private static (string, object)[] ConvertToParameters(IEnumerable<FieldInfo> properties, object data) =>
            properties.Select(p => ($"@{p.Name}", p.GetValue(data) ?? DBNull.Value)).ToArray();

        //Generated
        public static string BuildInsertStatement(string table, IEnumerable<string> columns, string[] returnColumns = null)
        {
            // Format the list of columns for the SQL statement
            var colList = string.Join(", ", columns.Select(FormatIdentifier));
            var valList = string.Join(", ", columns.Select(c => $"@{c}"));

            // Build the base insert statement
            var insertStatement = $"INSERT INTO {FormatIdentifier(table)} ({colList}) VALUES ({valList})";

            // If returnColumns is provided, add the OUTPUT clause
            if (returnColumns != null && returnColumns.Any())
            {
                var outputList = string.Join(", ", returnColumns.Select(c => $"INSERTED.{FormatIdentifier(c)}"));
                insertStatement = $"{insertStatement} OUTPUT {outputList}";
            }

            return insertStatement;
        }


        private static string BuildUpdateStatement(string table, IEnumerable<string> columns)
        {
            var setClause = string.Join(", ", columns.Select(c => $"{FormatIdentifier(c)} = @{c}"));
            return $"UPDATE {FormatIdentifier(table)} SET {setClause} WHERE {FormatIdentifier(table)}Id = @{table}Id";
        }

        private static string FormatIdentifier(string identifier) => $"`{identifier}`";
    }
}
