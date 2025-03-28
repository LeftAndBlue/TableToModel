﻿using System.Data;
using Microsoft.Data.SqlClient;
namespace SqlToModel
{
    class SqlHelper
    {
        public static Dictionary<string, string> SetSqlConnection(string strConnect, string tableName)
        {
            string connectionString = $"{strConnect};TrustServerCertificate=True";
            string sql = $"SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE" +
                $" FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}';";
            DataTable dt = new DataTable();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt); // 使用 DataAdapter 填充 DataTable
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            foreach (DataRow row in dt.Rows)
            {

                dic.Add(row[0].ToString(), ToType(row[1].ToString(), false));

            }
            return dic;
        }
        public static string ToType(string sqlType, bool isNull)
        {
            switch (sqlType.ToLower())
            {
                case "datetime":
                case "time":
                case "date":
                    return isNull ? "DateTime?" : "DateTime";
                case "int":
                case "smallint":
                    return isNull ? "int?" : "int";
                case "bigint":
                    return isNull ? "long?" : "long";
                case "decimal":
                    return isNull ? "decimal?" : "decimal";
                case "float":
                    return isNull ? "float?" : "float";
                case "double":
                case "real":
                    return isNull ? "double?" : "double";
                case "bit":
                case "tinyint":
                    return isNull ? "bool?" : "bool";
                case "timestamp":
                    return "byte[]";
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    return "string";
                case "binary":
                case "varbinary":
                case "image":
                    return "byte[]";
                case "uniqueidentifier":
                    return isNull ? "Guid?" : "Guid";
                case "sql_variant":
                    return "object";
                case "xml":
                    return "string";
                default:
                    return null;
            }
        }
    }
}
