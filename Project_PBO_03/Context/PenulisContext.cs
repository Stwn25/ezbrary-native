using System.Data;
using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Model;
using Project_PBO_03.Core;

namespace Project_PBO_03.Context
{
    internal class PenulisContext: DBconnection
    {
        public static string table = "penulis";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPenulis = queryExecutor(query);
            return dataPenulis;
        }

        public static void create(m_Penulis penulisBaru)
        {
            string query = $"INSERT INTO {table} (namapenulis) VALUES(@namapenulis)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namapenulis", NpgsqlDbType.Varchar){Value = penulisBaru.nama_penulis}
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id) 
        {
            string query = $"DELETE FROM {table} WHERE idpenulis = @idpenulis";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idpenulis", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }

    }
}
