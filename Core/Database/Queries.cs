using SearchAndRescue.Extensions;

namespace SearchAndRescue.Core.Database
{
    public static class Queries
    {
        public static string GetById(string columns, string table, string identifierColumn)
        {
            return $"SELECT {columns} FROM {table} WHERE {identifierColumn} = @p{identifierColumn.FromSnakeCase()};";
        }

        public static string GetById(string columns, string table, string[] identifierColumns)
        {
            return $"SELECT {columns} FROM {table} WHERE {identifierColumns.Select((column) => { return $"{column} = p{column.FromSnakeCase()}"; })};";
        }

        public static string Get(string columns, string table)
        {
            return $"SELECT {columns} FROM {table};";
        }

        public static string Insert(string columns, string tableName, string values)
        {
            return $"INSERT INTO {tableName} ({columns}) VALUES ({values}) RETURNING id;";
        }

        public static string Update(string columns, string tableName)
        {
            return $"UPDATE {tableName} SET {columns};";
        }

        public static string UpdateById(string columns, string tableName, string identifierColumn)
        {
            return $"UPDATE {tableName} SET {columns} WHERE {identifierColumn} = @p{identifierColumn.FromSnakeCase()};";
        }

        public static string UpdateById(string columns, string tableName, string[] identifierColumns)
        {
            return $"UPDATE {tableName} SET {columns} WHERE {identifierColumns.Select((column) => { return $"{column} = p{column.FromSnakeCase()}"; })};";
        }

        public static string DeleteById( string tableName, string identifierColumn)
        {
            return $"DELETE FROM {tableName} WHERE {identifierColumn} = @p{identifierColumn.Replace("_", "")};";
        }

        public static string DeleteById(string tableName, string[] identifierColumns)
        {
            return $"DELETE FROM {tableName} WHERE {identifierColumns.Select((column) => { return $"{column} = p{column.FromSnakeCase()}"; })};";
        }
    }
}
