using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System.Reflection;

namespace Bestellsystem_Lieferdienst_Server.DAL
{
    public class SqlCommand
    {
        public string SqlStatement { get; private set; } = string.Empty;
        public (string, object)[] Parameters { get; private set; } = [];

        public SqlCommand Insert<T>(string table, T data)
        {
            var properties = typeof(T).GetProperties();
            var columnNames = properties.Select(p => p.Name);

            SqlStatement = BuildInsertStatement(table, columnNames);
            Parameters = ConvertToParameters(properties, data);

            return this;
        }

        public SqlCommand Update<T>(string table, T data)
        {
            var properties = typeof(T).GetProperties();
            var columnNames = properties.Select(p => p.Name);

            SqlStatement = BuildUpdateStatement(table, columnNames);
            Parameters = ConvertToParameters(properties, data);

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

        private static (string, object)[] ConvertToParameters(PropertyInfo[] properties, object data) =>
            properties.Select(p => ($"@{p.Name}", p.GetValue(data) ?? DBNull.Value)).ToArray();

        private static string BuildInsertStatement(string table, IEnumerable<string> columns)
        {
            var colList = string.Join(", ", columns.Select(FormatIdentifier));
            var valList = string.Join(", ", columns.Select(c => $"@{c}"));
            return $"INSERT INTO {FormatIdentifier(table)} ({colList}) VALUES ({valList})";
        }

        private static string BuildUpdateStatement(string table, IEnumerable<string> columns)
        {
            var setClause = string.Join(", ", columns.Select(c => $"{FormatIdentifier(c)} = @{c}"));
            return $"UPDATE {FormatIdentifier(table)} SET {setClause} WHERE {FormatIdentifier(table)}Id = @{table}Id";
        }

        private static string FormatIdentifier(string identifier) => $"`{identifier}`";
    }
}
