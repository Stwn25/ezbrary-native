using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Core
{
    internal class cekLoginSuperAdmin
    {
        public static bool Login(string username_sa, string pass_sa)
        {
            try
            {
                string query = "SELECT * FROM superadmin WHERE username = @username AND pwsuper = @password";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = username_sa },
                    new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = pass_sa },
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

