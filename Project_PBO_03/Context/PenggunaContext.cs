using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;
using Project_PBO_03.Core;
using Project_PBO_03.Model;

namespace Project_PBO_03.Context
{
    internal class PenggunaContext : DBconnection
    {
        private static string table = "pengguna";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPengguna = queryExecutor(query);
            return dataPengguna;
        }

        public static DataTable read(int id)
        {
            string query = $"SELECT * FROM {table} WHERE iduser = @iduser";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer){Value = id},
            };
            DataTable dataPengguna = queryExecutor(query, parameters);
            return dataPengguna;
        }

        public static void create(m_Pengguna penggunaBaru)
        {
            string query = $"INSERT INTO {table} (namauser, usrnmeuser, pwuser, telpuser, emailuser) Values(@namauser, @usrnmeuser, @pwuser, @telpuser, @emailuser)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@namauser", NpgsqlDbType.Varchar){Value = penggunaBaru.nama_pengguna},
                new NpgsqlParameter ("@usrnmeuser", NpgsqlDbType.Varchar){Value = penggunaBaru.username_pengguna},
                new NpgsqlParameter ("@pwuser", NpgsqlDbType.Varchar){Value = penggunaBaru.pass_pengguna},
                new NpgsqlParameter ("@telpuser", NpgsqlDbType.Varchar){Value = penggunaBaru.telp_pengguna},
                new NpgsqlParameter ("@emailuser", NpgsqlDbType.Varchar){Value = penggunaBaru.email_pengguna},
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE iduser = @iduser";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }
    }
}
