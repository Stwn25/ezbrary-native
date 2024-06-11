using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Core;
using Project_PBO_03.Model;

namespace Project_PBO_03.Context
{
    internal class JenisBukuContext : DBconnection
    {
        public static string table = "jenisbuku";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataJenis = queryExecutor(query);
            return dataJenis;
        }

        public static DataTable comboBox()
        {
            string query = $"SELECT namajenis FROM {table}";
            DataTable dataJenis = queryExecutor(query);
            return dataJenis;
        }

        public static DataTable comboBoxUser(string namajenis)
        {
            string query = $"select b.isbn, b.namabuku, jb.namajenis, b.stokbuku, b.posisirak " +
                           $"from buku b join jenisbuku jb " +
                           $"ON jb.idjenis = b.jenisbuku_idjenis " +
                           $"join penulis ps " +
                           $"ON ps.idpenulis = b.penulis_idpenulis " +
                           $"join penerbit pt " +
                           $"ON pt.idpenerbit = b.penerbit_idpenerbit " +
                           $"where jb.namajenis = @namajenis";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namajenis", NpgsqlDbType.Varchar) {Value = namajenis},
            };

            DataTable dataBuku = queryExecutor(query, parameters);
            return dataBuku;
        }

        public static DataTable Jenis(string namajenis)
        {
            string query = $"select b.isbn, b.namabuku, b.sinopsis, b.thnterbit, jb.namajenis, b.stokbuku, pt.namapenerbit, ps.namapenulis, b.posisirak, b.statusbuku_idstatusbuku " +
                           $"from buku b join jenisbuku jb " +
                           $"ON jb.idjenis = b.jenisbuku_idjenis " +
                           $"join penulis ps " +
                           $"ON ps.idpenulis = b.penulis_idpenulis " +
                           $"join penerbit pt " +
                           $"ON pt.idpenerbit = b.penerbit_idpenerbit " +
                           $"join statusbuku sb " +
                           $"ON sb.idstatusbuku = b.statusbuku_idstatusbuku " +
                           $"where jb.namajenis = @namajenis";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namajenis", NpgsqlDbType.Varchar) {Value = namajenis},
            };

            DataTable dataBuku = queryExecutor(query, parameters);
            return dataBuku;
        }

        public static void create(m_JenisBuku jenisBaru)
        {
            string query = $"INSERT INTO {table} (namajenis) VALUES (@namajenis)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namajenis", NpgsqlDbType.Varchar) {Value = jenisBaru.nama_jenis}
            };
            commandExecutor(query, parameters);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE idpenerbit = @idjenis";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idjenis", NpgsqlDbType.Integer) {Value = id},
            };
            commandExecutor(query, parameters);
        }

    }
     
}
