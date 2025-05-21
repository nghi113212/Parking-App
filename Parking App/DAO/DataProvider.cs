using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAO
{
    public class DataProvider
    {
        private string connectionString = "Data Source=DESKTOP-O9MO0G2\\SOUTHSIDE;Initial Catalog = CarParkingDB; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        public DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        //string[] queryParts = query.Split(' ');
                        //int i = 0;
                        //foreach (string part in queryParts)
                        //{
                        //    if (part.Contains("@"))
                        //    {
                        //        command.Parameters.AddWithValue(part, parameters[i]);
                        //        i++;
                        //    }
                        //}

                        var matches = Regex.Matches(query, @"@\w+");
                        for (int i = 0; i < matches.Count && i < parameters.Length; i++)
                        {
                            command.Parameters.AddWithValue(matches[i].Value, parameters[i]);
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                connection.Close();
            }
            return dataTable;
        }

        //public int ExecuteNonQuery(string query, object[] parameters = null)
        //{
        //    int rowsAffected = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            if (parameters != null)
        //            {
        //                string[] queryParts = query.Split(' ');
        //                int i = 0;
        //                foreach (string part in queryParts)
        //                {
        //                    if (part.Contains("@"))
        //                    {
        //                        command.Parameters.AddWithValue(part, parameters[i]);
        //                        i++;
        //                    }
        //                }
        //            }

        //            rowsAffected = command.ExecuteNonQuery();
        //        }
        //        connection.Close();
        //    }
        //    return rowsAffected;
        //}

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] queryParts = query.Split(' ');
                        int i = 0;
                        foreach (string part in queryParts)
                        {
                            if (part.Contains("@"))
                            {
                                command.Parameters.AddWithValue(part, parameters[i]);
                                i++;
                            }
                        }
                    }

                    result = command.ExecuteScalar();
                }
                connection.Close();
            }
            return result;
        }
    }
}
