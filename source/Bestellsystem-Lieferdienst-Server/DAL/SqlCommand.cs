using Client_Server_Code_Library;
using System.Reflection;

namespace Bestellsystem_Lieferdienst_Server.DAL
{
    public class SqlCommand
    {
        //Trust me, this class will improve our all life :thumbsup: 
        public string SqlStatement { get; private set; } = string.Empty;
        public List<(string, object)> Parameters { get; private set; }


        public SqlCommand DeleteAllFromTable(string table)
        {
            SqlStatement = $"TRUNCATE TABLE {table}";
            return this;
        }

        public SqlCommand Insert<T>(string table, T data)
        {
            IEnumerable<MemberInfo> members = typeof(T).GetMembers()
                .Where(m => m.MemberType == MemberTypes.Field || m.MemberType == MemberTypes.Property)
                .Where(m => !Attribute.IsDefined(m, typeof(DatabaseAutoIncrementIDAttribute))) // Exclude auto-increment fields
                .Where(m => !Attribute.IsDefined(m, typeof(IgnoreInsertAttribute))); // Exclude ignored fields

            // Get the column names
            List<string> columnNames = members.Select(m => m.Name).ToList();

            SqlStatement = BuildInsertStatement(table, columnNames);

            Parameters = ConvertToParameters(members, data);

            return this;
        }

        private static List<(string, object)> ConvertToParameters(IEnumerable<MemberInfo> members, object data)
        {
            return members.Select(m =>
            {
                // reflection :gud:
                object value = m switch
                {
                    FieldInfo field => field.GetValue(data),
                    PropertyInfo property => property.GetValue(data),
                    _ => null
                };
                return ($"@{m.Name}", value ?? DBNull.Value);
            }).ToList();
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

        //1/2 Generated (Generated description)
        /// <summary>
        /// Builds a SQL SELECT statement that performs a JOIN between two tables and optionally filters results with WHERE and GROUP BY clauses.
        /// The SELECT statement returns all columns from the resulting joined tables (i.e., <c>SELECT *</c>).
        /// </summary>
        /// <param name="returnTable">The primary table to select data from.</param>
        /// <param name="joinTable">The table to join with the primary table.</param>
        /// <param name="joinIdentifier">
        /// An array of tuples defining the JOIN condition. Each tuple contains the column name from each table to be matched (e.g., (returnTableCol, joinTableCol)).
        /// </param>
        /// <param name="identifier">
        /// An optional array of tuples specifying filter conditions for the WHERE clause.
        /// Each tuple includes a column name and a corresponding value to filter by.
        /// </param>
        /// <param name="groupBy">
        /// An optional list of column names to group the results by (used in the GROUP BY clause).
        /// </param>
        /// <returns>
        /// A <see cref="SqlCommand"/> object representing the built SQL query with populated parameters.
        /// </returns>
        public SqlCommand SelectColumnsByJoin(
            string returnTable,
            string joinTable,
            IReadOnlyList<string> columns,
            (string, string)[]? joinIdentifier,
            (string, object)[]? identifier,
            IReadOnlyList<string>? groupBy = null)
        {
            string selectedColumns;

            if (columns.Count == 1 && columns[0] == "*")
            {
                selectedColumns = "*";
            }
            else
            {
                selectedColumns = string.Join(", ", columns.Select(FormatIdentifier));
            }

            Parameters = new List<(string, object)>(joinIdentifier.Length + identifier.Length);



            string joinCondition = string.Join(" AND ", joinIdentifier.Select(VARIABLE =>
                    $"{FormatIdentifier(VARIABLE.Item1)} = {VARIABLE.Item2}"
                )
            );

            string whereCondition = identifier?.Length > 0
                ? "WHERE " + string.Join(" AND ", identifier.Select(VARIABLE =>
                        {
                            string uniqueName = GetUniqueParameterName(VARIABLE.Item1);
                            Parameters.Add((uniqueName, VARIABLE.Item2));
                            return $"{FormatIdentifier(VARIABLE.Item1)} = @{uniqueName}";
                        }
                    )
                )
                : string.Empty;
            //string whereCondition = identifier?.Length > 0
            //    ? "WHERE " + string.Join(" AND ", identifier.Select(i => $"{FormatIdentifier(i.Item1)} = @{i.Item1}"))
            //    : string.Empty; // no WHERE clause

            // Build GROUP BY condition (if provided)
            string groupByClause = groupBy != null && groupBy.Count > 0
                ? "GROUP BY " + string.Join(", ", groupBy.Select(FormatIdentifier))
                : string.Empty; // no GROUP BY clause if null or empty

            // Final SQL Statement
            SqlStatement = $"SELECT {selectedColumns} FROM {FormatIdentifier(returnTable)} " +
                $"JOIN {FormatIdentifier(joinTable)} ON {joinCondition} " +
            $"{whereCondition} {groupByClause}";

            return this;
        }

        public SqlCommand SelectAll(string table)
        {
            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)}";
            return this;
        }

        public SqlCommand SelectByNonPredefined(string table, List<(string, object)> identifier)
        {
            var conditions = string.Join(" AND ", identifier.Select(i => $"{FormatIdentifier(i.Item1)} = @{i.Item1}"));

            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)} WHERE {conditions}";
            Parameters = identifier;

            return this;
        }

        public SqlCommand SelectById(string table, long id)
        {
            var idParam = CreateIdParameter(table, id);
            SqlStatement = $"SELECT * FROM {FormatIdentifier(table)} WHERE {FormatIdentifier(table + "Id")} = @{table}Id";
            Parameters = idParam;

            return this;
        }

        public SqlCommand SelectColumnsById(string table, IReadOnlyList<string> columns, long id)
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

        private static List<(string, object)> CreateIdParameter(string table, long id) =>
            [($"@{table}Id", id)];

        //Generated 1/2
        private static string BuildInsertStatement(string table, IEnumerable<string> columns)
        {
            // Format the list of columns for the SQL statement
            var colList = string.Join(", ", columns.Select(FormatIdentifier));
            var valList = string.Join(", ", columns.Select(c => $"@{c}"));

            // Build the base insert statement
            var insertStatement = $"INSERT INTO {FormatIdentifier(table)} ({colList}) VALUES ({valList})";

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
