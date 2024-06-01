using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Project_PBO_03.Model
{
    internal class DBconnection
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "peminjamanbuku";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "LordSuram";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlCommand command;
        private static NpgsqlConnection conn;

        public static void OpenConnection()
        {
            conn = new NpgsqlConnection($"Host={DB_HOST};Port={DB_PORT};Database={DB_DATABASE};User Id={DB_USERNAME};Password={DB_PASSWORD};");
            conn.Open();
            command = new NpgsqlCommand();
            command.Connection = conn;
        }

        public static void CloseConnection()
        {
            conn.Close();
            command.Parameters.Clear();
        }

        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                CloseConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}