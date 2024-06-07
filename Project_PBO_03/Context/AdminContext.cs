using Project_PBO_03.Core;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Model;

namespace Project_PBO_03.Context
{
    internal class AdminContext : DBconnection
    {
        private static string table = "administrator";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataAdministrator = queryExecutor(query);
            return dataAdministrator;
        }

        public static DataTable read(int idadmin)
        {
            string query = $"SELECT * FROM {table} WHERE idadmin = @idadmin";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idadmin", NpgsqlDbType.Integer) { Value = idadmin }
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

        // Method update yang menerima parameter individual
        public static void update(int idadmin, string kodeverifikasi, string namaadmin, string telpadmin, string usrnmeadmin, string pwadmin, string emailadmin)
        {
            string query = $"UPDATE {table} SET kodeverifikasi = @kodeverifikasi, namaadmin = @namaadmin, telpadmin = @telpadmin, usrnmeadmin = @usrnmeadmin, pwadmin = @pwadmin, emailadmin = @emailadmin WHERE idadmin = @idadmin";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idadmin", NpgsqlDbType.Integer){Value = idadmin },
                new NpgsqlParameter("@kodeverifikasi", NpgsqlDbType.Varchar){Value = kodeverifikasi},
                new NpgsqlParameter("@namaadmin", NpgsqlDbType.Varchar){Value = namaadmin},
                new NpgsqlParameter("@telpadmin", NpgsqlDbType.Varchar){Value = telpadmin},
                new NpgsqlParameter("@usrnmeadmin", NpgsqlDbType.Varchar){Value = usrnmeadmin},
                new NpgsqlParameter("@pwadmin", NpgsqlDbType.Varchar){Value = pwadmin},
                new NpgsqlParameter("@emailadmin", NpgsqlDbType.Varchar){Value = emailadmin},
            };
            commandExecutor(query, parameters);
        }
    }
}
