using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 職業性ストレス簡易調査
{
    internal static class Rdb
    {
        private static SqlConnection? _conn = null;

        public static SqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    // connect to SQL Server
                    var connString = @"Data Source=localhost¥SQLEXPRESS;"
                                   + "Initial Catalog=Stress_check;"
                                   + "Persist Security Info=False;"
                                   + "Integrated Security=SSPI;"
                                   + "Encrypt=False;";
                    try
                    {
                        _conn = new(connString);
                        _conn.Open();
                    }
                    catch (SqlException ex)
                    {
                        ErrorMessage(ex);
                        Environment.Exit(ex.ErrorCode);
                    }
                }
                return _conn;
            }
        }

        public static void Disconnect()
        {
            if (_conn != null)
            {
                _conn.Close();
                _conn.Dispose();
                _conn = null;
            }
        }

        public static void ErrorMessage(SqlException ex)
        {
            var errooeMessages = new StringBuilder();
            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errooeMessages.Append($"Index #[i]\n"
                    + $"Server; {ex.Errors[i].Server}\n"
                    + $"Message; {ex.Errors[i].Message}\n"
                    + $"LineNumber; {ex.Errors[i].LineNumber}\n"
                    + $"Source; {ex.Errors[i].Source}\n"
                    + $"Procedure; {ex.Errors[i].Procedure}\n");
            }
            MessageBox.Show(errooeMessages.ToString(), "SQLエラー");
        }
    }
}
