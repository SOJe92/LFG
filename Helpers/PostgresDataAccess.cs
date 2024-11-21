using Dapper;
using SearchAndRescue.Core.Database.Attributes;
using SearchAndRescue.Extensions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;

namespace SearchAndRescue.Helpers
{
    public static class PostgresDataAccess
    {
        public static void BuildQuery<T>(T obj, out string tableName, out string columnNames, out string parameters)
        {
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columnNames = string.Join(", ", definedProperties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            parameters = string.Join(", ", definedProperties.Select(p => $"@{p.GetCustomAttribute<ColumnAttribute>().Name}"));
        }
        public static void BuildQuery<T>(T obj, out string tableName, out string columnNames, out string parameters, out DynamicParameters parametersModel, string? idColumn = null)
        {
            parametersModel = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columnNames = string.Join(", ", definedProperties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            parameters = string.Join(", ", definedProperties.Select(p => $"@{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            if (idColumn != null)
            {
                foreach (PropertyInfo? property in properties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    if (columnName == idColumn)
                    {
                        DbType dbType = ConvertToDbType(property.PropertyType);
                        object? value = property.GetValue(obj);
                        parametersModel.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
                    }
                }
            }
        }
        public static void BuildQuery<T>(T obj, out string tableName, out string columnNames, out string parameters, out DynamicParameters parametersModel, string[] idColumn)
        {
            parametersModel = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columnNames = string.Join(", ", definedProperties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            parameters = string.Join(", ", definedProperties.Select(p => $"@{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            if (idColumn.Length > 0)
            {
                foreach (PropertyInfo? property in properties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    if (idColumn.Contains(columnName))
                    {
                        DbType dbType = ConvertToDbType(property.PropertyType);
                        object? value = property.GetValue(obj);
                        parametersModel.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
                    }
                }
            }
        }

        public static void BuildGetQuery<T>(out string tableName, out string columns)
        {
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columns = string.Join(", ", properties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
        }

        public static void BuildGetQuery<T>(T obj, out string tableName, out string columns, out DynamicParameters parameters, string? idColumn = null)
        {
            parameters = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columns = string.Join(", ", properties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            if (idColumn != null)
            {
                foreach (PropertyInfo? property in properties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    if (columnName == idColumn)
                    {
                        DbType dbType = ConvertToDbType(property.PropertyType);
                        object? value = property.GetValue(obj);
                        parameters.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
                    }
                }
            }
        }

        public static void BuildGetQuery<T>(T obj, out string tableName, out string columns, out DynamicParameters parameters, string[] idColumn)
        {
            parameters = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columns = string.Join(", ", properties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}"));
            if (idColumn.Length > 0)
            {
                foreach (PropertyInfo? property in properties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    if (idColumn.Contains(columnName))
                    {
                        DbType dbType = ConvertToDbType(property.PropertyType);
                        object? value = property.GetValue(obj);
                        parameters.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
                    }
                }
            }
        }

        public static void BuildUpdateQuery<T>(T obj, out string tableName, out string setValues, out DynamicParameters parameters, string? idColumn = null)
        {
            parameters = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            setValues = string.Join(", ", definedProperties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name} = @{p.GetValue(p).ToString().FromSnakeCase()}"));
            if (idColumn != null)
            {
                foreach (PropertyInfo? property in properties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    if (columnName == idColumn)
                    {
                        DbType dbType = ConvertToDbType(property.PropertyType);
                        object? value = property.GetValue(obj);
                        parameters.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
                    }
                }
            }
        }

        public static void BuildUpdateQuery<T>(T obj, out string tableName, out string setValues, out DynamicParameters parameters, string[] idColumn)
        {
            parameters = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            setValues = string.Join(", ", definedProperties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name} = @p{p.GetCustomAttribute<ColumnAttribute>().Name.FromSnakeCase()}"));
            if (idColumn.Length > 0)
            {
                foreach (PropertyInfo? property in definedProperties)
                {
                    ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                    string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                    DbType dbType = ConvertToDbType(property.PropertyType);
                    object? value = property.GetValue(obj);
                    parameters.Add($"p{columnName.FromSnakeCase()}", value, dbType, direction);
                }
            }
        }

        public static void BuildDeleteQuery<T>(T obj, out string tableName)
        {
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            IEnumerable<PropertyInfo>? definedProperties = properties.Where(x =>
            {
                object? objectValue = x.GetValue(obj);
                return objectValue != null && !string.IsNullOrEmpty(objectValue.ToString()) && !Equals(objectValue, Guid.Empty);
            });
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
        }

        public static void BuildQuery<T>(out string tableName, out string columnNames)
        {
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null);
            tableName = ((TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute))).Name;
            columnNames = string.Join(", ", properties.Select(p => $"{p.GetCustomAttribute<ColumnAttribute>().Name}  AS {p.Name}"));
        }

        public static void BuildParams<T>(T obj, out DynamicParameters parameters)
        {
            parameters = new();
            Type type = typeof(T);
            IEnumerable<PropertyInfo>? properties = type.GetProperties().Where(x => (DapperParamDirectionAttribute?)Attribute.GetCustomAttribute(x, typeof(DapperParamDirectionAttribute)) != null);
            properties = properties.OrderBy(x => ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(x, typeof(DapperParamDirectionAttribute))).Value);
            IEnumerable<PropertyInfo>? definedProperties = type.GetProperties().Where(x => (ColumnAttribute?)Attribute.GetCustomAttribute(x, typeof(ColumnAttribute)) != null && x.GetValue(obj) != null);
            foreach (PropertyInfo? property in definedProperties)
            {
                ParameterDirection direction = ((DapperParamDirectionAttribute)Attribute.GetCustomAttribute(property, typeof(DapperParamDirectionAttribute))).Value;
                string columnName = ((ColumnAttribute)Attribute.GetCustomAttribute(property, typeof(ColumnAttribute))).Name;
                object? value = property.GetValue(obj);
                DbType dbType = ConvertToDbType(property.PropertyType);
                value ??= (dbType == DbType.String ? "" : DBNull.Value);
                parameters.Add($"@p{columnName.FromSnakeCase()}", value, dbType, direction);
            }
        }

        private static DbType ConvertToDbType(Type type)
        {
            return Type.GetTypeCode(type) switch
            {
                TypeCode.String => DbType.String,
                TypeCode.Int32 => DbType.Int32,
                TypeCode.Decimal => DbType.Decimal,
                TypeCode.Int64 => DbType.Int64,
                TypeCode.UInt64 => DbType.UInt64,
                TypeCode.Single => DbType.Single,
                TypeCode.Double => DbType.Double,
                TypeCode.Object => DbType.Object,
                TypeCode.Char => DbType.String,
                TypeCode.DateTime => DbType.DateTime,
                TypeCode.Boolean => DbType.Boolean,
                _ => throw new ArgumentException($"Type {type.Name} is not supported."),
            };
        }
    }
}
