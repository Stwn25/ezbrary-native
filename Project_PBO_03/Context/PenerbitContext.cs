using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;
using Project_PBO_03.Core;
using Project_PBO_03.Model;
using System.Data;

namespace Project_PBO_03.Context
{
    internal class PenerbitContext : DBconnection
    {
        private static string table = "penerbit";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPenerbit = queryExecutor(query);
            return dataPenerbit;
        }

        public static DataTable comboBox()
        {
            string query = $"SELECT idpenerbit, namapenerbit FROM {table}";
            DataTable dataPenerbit = queryExecutor(query);
            return dataPenerbit;
        }

        public static DataTable read(int id)
        {
            string query = $"SELECT * FROM {table} WHERE idpenerbit = @idpenerbit";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idpenerbit", NpgsqlDbType.Integer){Value = id},
            };
            DataTable dataPenerbit = queryExecutor(query, parameters);
            return dataPenerbit;
        }

        public static void create(m_Penerbit penerbitBaru)
        {
            string query = $"INSERT INTO {table} (namapenerbit, alamatpenerbit) VALUES(@namapenerbit, @alamatpenerbit)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namapenerbit", NpgsqlDbType.Varchar){Value = penerbitBaru.nama_penerbit},
                new NpgsqlParameter("@alamatpenerbit", NpgsqlDbType.Text){Value = penerbitBaru.alamat_penerbit},
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE idpenerbit = @idpenerbit";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idpenerbit", NpgsqlDbType.Integer) {Value = id},
            };
            commandExecutor(query, parameters);
        }

        public static void update(m_Penerbit penerbitEdit)
        {
            string query = $"UPDATE {table} SET namapenerbit = @namapenerbit, alamatpenerbit = @alamatpenerbit WHERE idpenerbit = @idpenerbit";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namapenerbit", NpgsqlDbType.Varchar) {Value = penerbitEdit.nama_penerbit},
                new NpgsqlParameter("@alamatpenerbit", NpgsqlDbType.Text){Value = penerbitEdit.alamat_penerbit},
                new NpgsqlParameter("@idpenerbit", NpgsqlDbType.Integer){Value = penerbitEdit.id_penerbit},
            };
            commandExecutor(query, parameters);
        }
    }
}
