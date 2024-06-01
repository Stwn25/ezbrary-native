using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Project_PBO_03.Core;
using NpgsqlTypes;
using Project_PBO_03.Model;

namespace Project_PBO_03.Context
{
    internal class AdminContext : DBconnection
    {
        private static string table = "administrator";

        public static DataTable all()
        {
            string query = $"SELECT * from {table}";
            DataTable dataAdministrator = queryExecutor(query);
            return dataAdministrator;
        }

        public static DataTable read(int idadmin)
        {
            string query = $"SELECT * FROM {table} WHERE idadmin = @idadmin";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = idadmin }
            };
            DataTable dataAdministrator = queryExecutor(query, parameters);
            return dataAdministrator;
        }

        public static void create(m_Administrator newAdmin)
        {
            string query = $"INSERT INTO {table}(idadmin, kodeverifikasi, namaadmin, telpadmin, usrnmeadmin, pwadmin, emailadmin) VALUES(@idadmin, @kodeverifikasi, @namaadmin, @telpadmin, @usrnmeadmin, @pwadmin, @emailadmin)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idadmin", NpgsqlDbType.Integer){Value = newAdmin.id_admin},
                new NpgsqlParameter("@kodeverifikasi", NpgsqlDbType.Varchar){Value = newAdmin.kode_verif},
                new NpgsqlParameter("@namaadmin", NpgsqlDbType.Varchar){Value = newAdmin.nama_admin},
                new NpgsqlParameter("@telpadmin", NpgsqlDbType.Varchar){Value = newAdmin.telp_admin},
                new NpgsqlParameter("@usrnmeadmin", NpgsqlDbType.Varchar){Value = newAdmin.username_admin},
                new NpgsqlParameter("@pwadmin", NpgsqlDbType.Varchar){Value = newAdmin.pass_admin},
                new NpgsqlParameter("@emailadmin", NpgsqlDbType.Varchar){Value = newAdmin.email_admin},
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE idadmin = @idadmin";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idadmin", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }

        public static void update(m_Administrator editMahasiswa)
        {
            string query = $"UPDATE {table} SET idadmin = @idadmin, kodeverifikasi = @kodeverifikasi, namaadmin = @namaadmin, telpadmin = @telpadmin, usrnmeadmin = @usrnmeadmin, pwadmin = @pwadmin, emailadmin = @emailadmin";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idadmin", NpgsqlDbType.Integer){Value = editMahasiswa.id_admin },
                new NpgsqlParameter("@kodeverifikasi", NpgsqlDbType.Varchar){Value = editMahasiswa.kode_verif},
                new NpgsqlParameter("@namaadmin", NpgsqlDbType.Varchar){Value = editMahasiswa.nama_admin},
                new NpgsqlParameter("@telpadmin", NpgsqlDbType.Varchar){Value = editMahasiswa.telp_admin},
                new NpgsqlParameter("@usrnmeadmin", NpgsqlDbType.Varchar){Value = editMahasiswa.username_admin},
                new NpgsqlParameter("@pwadmin", NpgsqlDbType.Varchar){Value = editMahasiswa.pass_admin},
                new NpgsqlParameter("@emailadmin", NpgsqlDbType.Varchar){Value = editMahasiswa.email_admin},
            };
            commandExecutor(query, parameters);
        }
    }
}