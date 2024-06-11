using System;
using System.Data;
using Npgsql;
using NpgsqlTypes;
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

        public static DataTable read(string username)
        {
            string query = $"SELECT iduser FROM {table} WHERE usrnmeuser = @username";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username){NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar}
            };
            DataTable idUser = queryExecutor(query, parameters);
            return idUser;
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

        public static DataTable login(string username, string password)
        {
            string query = "SELECT * FROM pengguna WHERE usrnmeuser = @input AND pwuser =@password";
            NpgsqlParameter[] parameters =
            {
                    new NpgsqlParameter("@input", DbType.String) {Value = username },
                    new NpgsqlParameter("@password", DbType.String) {Value = password },
                };
            return queryExecutor(query, parameters);
        }

        public static DataTable datauser(string input)
        {
            string query = "SELECT * FROM pengguna WHERE usrnmeuser = @user";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@user", input){NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar}
            };
            return queryExecutor(query, parameters);
        }
    }
}
