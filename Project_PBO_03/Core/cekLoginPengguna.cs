using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Project_PBO_03.Core
{
    internal class cekLoginPengguna
    {
        public static bool Login(string input_pengguna, string pass_pengguna)
        {
            try
            {
                string query = "SELECT * FROM pengguna WHERE (usrnmeuser = @input OR telpuser = @input OR emailuser = @input) AND pwuser = @password";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@input", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = input_pengguna },
                    new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = pass_pengguna },
                };

                DataTable result = DBconnection.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Login gagal! Username atau password salah.");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi kesalahan: {e.Message}");
                return false;
            }
        }
    }
}