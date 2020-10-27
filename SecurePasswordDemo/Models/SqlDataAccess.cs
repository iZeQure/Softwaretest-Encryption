using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SecurePasswordDemo.Models
{
    public class SqlDataAccess : IDisposable
    {
        private static SqlDataAccess instance = null;
        private SqlConnection _sqlConnection;

        public SqlConnection SqlConnection { get => _sqlConnection; set => _sqlConnection = value; }

        public static SqlDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    return instance = new SqlDataAccess();
                }
                return instance;
            }
        }

        public SqlDataAccess()
        {
            SqlConnection = new SqlConnection(GetSqlConnectionString());
        }

        public void OpenConnection()
        {
            try
            {
                if (string.IsNullOrEmpty(SqlConnection.ConnectionString))
                    return;
                else
                {
                    if (SqlConnection.State != ConnectionState.Open)
                    {
                        if (SqlConnection.State != ConnectionState.Connecting)
                            SqlConnection.Open();
                        else
                        {
                            int counter = 10;

                            do
                            {
                                counter--;

                                if (counter == 0)
                                {
                                    if (SqlConnection.State == ConnectionState.Connecting)
                                        counter = 10;
                                    else
                                        SqlConnection.Open();
                                }
                            } while (SqlConnection.State == ConnectionState.Connecting);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine($"Couldn't Open Connection.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled Exception : {e.Message}");
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (SqlConnection.State != ConnectionState.Closed) SqlConnection.Close();

                return;
            }
            catch (SqlException)
            {
                Console.WriteLine($"Couldn't Close Connection.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetSqlConnectionString()
        {
            return $"Server=IGEIRISS\\SQLDEV; Database=SecurePasswordDemoDB; Integrated Security=true;";
        }

        public void Dispose()
        {
            ((IDisposable)Instance).Dispose();
        }
    }
}
