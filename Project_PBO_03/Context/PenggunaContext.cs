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

        public static DataTable read(string identifier, bool isUsername)
        {
            string query;
            NpgsqlParameter[] parameters;

            if (isUsername)
            {
                query = "SELECT * FROM pengguna WHERE usrnmeuser = @username";
                parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@username", NpgsqlDbType.Varchar) { Value = identifier }
                };
            }
            else
            {
                query = "SELECT * FROM pengguna WHERE iduser = @id";
                parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = int.Parse(identifier) }
                };
            }

            return DBconnection.queryExecutor(query, parameters);
        }

        public static void create(m_Pengguna penggunaBaru)
        {
            string query = $"INSERT INTO {table} (namauser, usrnmeuser, pwuser, telpuser, emailuser) VALUES (@namauser, @usrnmeuser, @pwuser, @telpuser, @emailuser)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namauser", NpgsqlDbType.Varchar) { Value = penggunaBaru.nama_pengguna },
                new NpgsqlParameter("@usrnmeuser", NpgsqlDbType.Varchar) { Value = penggunaBaru.username_pengguna },
                new NpgsqlParameter("@pwuser", NpgsqlDbType.Varchar) { Value = penggunaBaru.pass_pengguna },
                new NpgsqlParameter("@telpuser", NpgsqlDbType.Varchar) { Value = penggunaBaru.telp_pengguna },
                new NpgsqlParameter("@emailuser", NpgsqlDbType.Varchar) { Value = penggunaBaru.email_pengguna }
            };
            commandExecutor(query, parameters);
        }

        public static void update(m_Pengguna editpengguna)
        {
            string query = $"UPDATE {table} SET namauser = @namauser, usrnmeuser = @usrnmeuser, pwuser = @pwuser, telpuser = @telpuser, emailuser = @emailuser WHERE iduser = @iduser";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) { Value = editpengguna.id_pengguna },
                new NpgsqlParameter("@namauser", NpgsqlDbType.Varchar) { Value = editpengguna.nama_pengguna },
                new NpgsqlParameter("@usrnmeuser", NpgsqlDbType.Varchar) { Value = editpengguna.username_pengguna },
                new NpgsqlParameter("@pwuser", NpgsqlDbType.Varchar) { Value = editpengguna.pass_pengguna },
                new NpgsqlParameter("@telpuser", NpgsqlDbType.Varchar) { Value = editpengguna.telp_pengguna },
                new NpgsqlParameter("@emailuser", NpgsqlDbType.Varchar) { Value = editpengguna.email_pengguna }
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE iduser = @iduser";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) { Value = id }
            };
            commandExecutor(query, parameters);
        }

        public static DataTable login(string username, string password)
        {
            string query = "SELECT * FROM pengguna WHERE usrnmeuser = @input AND pwuser = @password";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@input", DbType.String) { Value = username },
                new NpgsqlParameter("@password", DbType.String) { Value = password }
            };
            return queryExecutor(query, parameters);
        }

        public static DataTable datauser(string input)
        {
            string query = "SELECT * FROM pengguna WHERE usrnmeuser = @user";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@user", NpgsqlDbType.Varchar) { Value = input }
            };
            return queryExecutor(query, parameters);
        }
    }
}
