using Project_PBO_03.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Project_PBO_03.Model;
using NpgsqlTypes;

namespace Project_PBO_03.Context
{
    internal class BukuContext : DBconnection
    {
        private static string table = "buku";
      
        public static DataTable buku()
        {
            string query = $"select b.namabuku, b.isbn, b.posisirak, jb.namajenis, b.stokbuku" +
                           $"\r\nfrom buku b join jenisbuku jb \r\nON jb.idjenis = b.jenisbuku_idjenis" +
                           $"\r\njoin penulis ps \r\nON ps.idpenulis = b.penulis_idpenulis" +
                           $"\r\njoin penerbit pt\r\nON pt.idpenerbit = b.penerbit_idpenerbit " +
                           $"join statusbuku sb on sb.idstatusbuku = b.statusbuku_idstatusbuku " +
                           $"where b.statusbuku_idstatusbuku = 1";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        public static void aktif(string isbn)
        {
            string query = $"update {table} set statusbuku_idstatusbuku = 1 where isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn},
            };
            commandExecutor(query, parameters);
        }

        public static void nonaktif(string isbn)
        {
            string query = $"update {table} set statusbuku_idstatusbuku = 2 where isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn},
            };
            commandExecutor(query, parameters);
        }

        public static DataTable all()
        {
            string query = $"select b.isbn, b.namabuku, b.sinopsis, b.thnterbit, jb.namajenis, b.stokbuku, pt.namapenerbit, ps.namapenulis, b.posisirak, b.statusbuku_idstatusbuku" +
                           $"\r\nfrom buku b join jenisbuku jb \r\nON jb.idjenis = b.jenisbuku_idjenis" +
                           $"\r\njoin penulis ps \r\nON ps.idpenulis = b.penulis_idpenulis" +
                           $"\r\njoin penerbit pt\r\nON pt.idpenerbit = b.penerbit_idpenerbit " +
                           $"join statusbuku sb on sb.idstatusbuku = b.statusbuku_idstatusbuku";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        public static DataTable detailbuku(string namabuku)
        {
            string query = $"select b.isbn, b.namabuku, b.sinopsis, b.thnterbit, jb.namajenis, b.stokbuku, pt.namapenerbit, ps.namapenulis, b.posisirak" +
                           $"\r\nfrom buku b join jenisbuku jb \r\nON jb.idjenis = b.jenisbuku_idjenis" +
                           $"\r\njoin penulis ps \r\nON ps.idpenulis = b.penulis_idpenulis" +
                           $"\r\njoin penerbit pt\r\nON pt.idpenerbit = b.penerbit_idpenerbit" +
                           $" where b.namabuku = @namabuku";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namabuku", NpgsqlDbType.Varchar) { Value = namabuku }
            };

            return queryExecutor(query, parameters);
        }

        public static DataTable read(string isbn)
        {
            string query = $"select * from {table} where isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn},
            };
            DataTable dataBuku = queryExecutor(query, parameters);
            return dataBuku;
        }

        /*public static DataTable*/

        public static DataTable showBySearch(string pencarian)
        {
            string query = $"select b.isbn, b.namabuku, b.thnterbit, pt.namapenerbit, ps.namapenulis " +
                           $"\r\nfrom buku b " +
                           $"\r\njoin penulis ps \r\nON ps.idpenulis = b.penulis_idpenulis " +
                           $"\r\njoin penerbit pt\r\nON pt.idpenerbit = b.penerbit_idpenerbit " +
                           $"\r\nwhere namabuku ilike'%{pencarian}%'or namapenerbit ilike'%{pencarian}%'or namapenulis ilike'%{pencarian}%'" +
                           $"\r\norder by namabuku, namapenerbit, namapenulis ";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        public static void create(m_Buku bukuBaru)
        {
            string query = $"INSERT INTO {table} (isbn, namabuku, sinopsis, thnterbit, jenisbuku_idjenis, stokbuku, penerbit_idpenerbit, penulis_idpenulis, posisirak, statusbuku_idstatusbuku) " +
                           $"VALUES (@isbn, @namabuku, @sinopsis, @tahunterbit, @jenisbuku, @stokbuku, @penerbit, @penulis, @posisirak, @statusbuku)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@isbn", NpgsqlDbType.Varchar){Value = bukuBaru.isbn},
                new NpgsqlParameter ("@namabuku", NpgsqlDbType.Varchar){Value=bukuBaru.nama_buku},
                new NpgsqlParameter ("@sinopsis", NpgsqlDbType.Text){Value=bukuBaru.sinopsis},
                new NpgsqlParameter ("@tahunterbit", NpgsqlDbType.Varchar){Value=bukuBaru.thn_terbit},
                new NpgsqlParameter ("@jenisbuku", NpgsqlDbType.Integer){Value=bukuBaru.jenis_id},
                new NpgsqlParameter ("@stokbuku", NpgsqlDbType.Integer){Value=bukuBaru.stok_buku},
                new NpgsqlParameter ("@penerbit", NpgsqlDbType.Integer){Value=bukuBaru.penerbit_id},
                new NpgsqlParameter ("@penulis", NpgsqlDbType.Integer){Value=bukuBaru.penulis_id},
                new NpgsqlParameter ("@posisirak", NpgsqlDbType.Varchar){Value=bukuBaru.posisi_rak},
                new NpgsqlParameter ("@statusbuku", NpgsqlDbType.Integer){Value = 1}
            };
            commandExecutor(query, parameters);
        }

        public static void delete(string isbn)
        {
            string query = $"DELETE FROM {table} WHERE isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn},
            };
            commandExecutor(query, parameters);
        }

        public static void kurangistok(string isbn)
        {
            string query = $"UPDATE {table} SET stokbuku = stokbuku - 1 WHERE isbn = @isbn";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn}
            };
            commandExecutor(query, param);
        }

        public static void tambahstok(string isbn)
        {
            string query = $"UPDATE {table} SET stokbuku = stokbuku + 1 WHERE isbn = @isbn";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn}
            };
            commandExecutor(query, param);
        }
    }
}
