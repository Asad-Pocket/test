using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class task
    {
            
        private string _connectionString;

        public task(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlCommand CreateCommand(string sql)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                return command;
            }

            public void ExecuteCommand(string sql)
            {
                using var command = CreateCommand(sql);
                command.ExecuteNonQuery();
            }

            public List<Dictionary<string, object>> ExecuteQuery(string query)
            {
                using var command = CreateCommand(query);
                List<Dictionary<string, object>> values = new List<Dictionary<string, object>>();


                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    values.Add(row);
                }

                return values;
            }
        }
    }


