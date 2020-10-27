using SecurePasswordDemo.Data;
using SecurePasswordDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace SecurePasswordDemo.Services
{
    public class DatabaseService
    {
        private SqlDataAccess DB { get => SqlDataAccess.Instance; }

        public void CreateUser(User user)
        {
            try
            {
                using var command_createUser = new SqlCommand()
                {
                    CommandText = "proc_createuser",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DB.SqlConnection
                };

                command_createUser.Parameters.AddWithValue("@firstName", user.FirstName);
                command_createUser.Parameters.AddWithValue("@lastName", user.LastName);
                command_createUser.Parameters.AddWithValue("@userName", user.UserName);
                command_createUser.Parameters.AddWithValue("@secret", user.Password);
                command_createUser.Parameters.AddWithValue("@peppers", user.Salt);

                try
                {
                    DB.OpenConnection();
                    command_createUser.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception Occurred while operating in the database; {ex.Message}");
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred while creating User; {ex.Message}");
            }
        }

        public bool VerifyUser(User user)
        {
            try
            {
                using var c = new SqlCommand()
                {
                    CommandText = "proc_verifyuserlogin",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DB.SqlConnection
                };

                c.Parameters.AddWithValue("@userName", user.UserName);
                c.Parameters.AddWithValue("@secret", user.Password);

                var isVerified = c.Parameters.AddWithValue("@isVerified", SqlDbType.Bit);
                isVerified.Direction = ParameterDirection.Output;

                try
                {
                    DB.OpenConnection();

                    c.ExecuteNonQuery();

                    if ((int)isVerified.Value == 0) return false;
                    else
                        return true;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Exception occurred while getting the verification.");
                    return false;
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception Occurred while verifying user.");
                return false;
            }
        }

        public string GetUserSaltByUserName(string userName)
        {
            try
            {
                using var c = new SqlCommand()
                {
                    CommandText = "proc_getusersalt",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DB.SqlConnection
                };

                c.Parameters.AddWithValue("@userName", userName);

                try
                {
                    DB.OpenConnection();

                    SqlDataReader r = c.ExecuteReader();

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            return r.GetString(0);
                        }
                    }
                    else
                        return string.Empty;
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception occurred while getting user salt.");
            }

            return string.Empty;
        }

        public int GetUserLoginAttemptsByUserName(string userName)
        {
            try
            {
                using var c = new SqlCommand()
                {
                    CommandText = "proc_getloginattempts",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DB.SqlConnection
                };

                c.Parameters.AddWithValue("@userName", userName);

                try
                {
                    DB.OpenConnection();

                    SqlDataReader r = c.ExecuteReader();

                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            return r.GetInt32(0);
                        }
                    }
                    else
                        return 0;
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception occurred while getting login attempts.");
                return 0;
            }

            return 0;
        }

        public void LockAccount(string userName)
        {
            try
            {
                using var c = new SqlCommand()
                {
                    CommandText = "proc_lockaccount",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DB.SqlConnection
                };

                c.Parameters.AddWithValue("@userName", userName);

                try
                {
                    DB.OpenConnection();
                    c.ExecuteNonQuery();
                }
                finally
                {
                    DB.CloseConnection();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception occurred locking account.");
            }
        }
    }
}
