using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Core;
using Project_PBO_03.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Context
{
    internal class UlasanContext : DBconnection
    {
        private static string table = "ulasanbuku";

        public static void create(m_UlasanBuku ulasanUser)
        {
            string query = $"INSERT INTO {table} (ulasan, buku_isbn, pengguna_iduser) " +
                           $"VALUES (@ulasan, @isbn, @iduser)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@ulasan", NpgsqlDbType.Text){Value = ulasanUser.ulasan_buku},
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar) {Value = ulasanUser.isbn},
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value = ulasanUser.id_user}
            };
            commandExecutor(query, parameters);
        }

        public static DataTable ulasanBuku(string isbn)
        {
            string query =  $"select p.namauser, ub.ulasan " +
                            $"from ulasanbuku ub join pengguna p " +
                            $"on p.iduser = ub.pengguna_iduser " +
                            $"join buku b " +
                            $"ON b.isbn = ub.buku_isbn " +
                            $"where b.isbn = @isbn ";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar) { Value = isbn }
            };

            return queryExecutor(query, parameters);
        }

        
    }
}
