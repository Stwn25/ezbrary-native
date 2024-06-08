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

        public static DataTable all()
        {
            string query = $"select b.isbn, b.namabuku, b.sinopsis, b.thnterbit, jb.namajenis, b.stokbuku, pt.namapenerbit, ps.namapenulis, b.posisirak" +
                           $"\r\nfrom buku b join jenisbuku jb \r\nON jb.idjenis = b.jenisbuku_idjenis" +
                           $"\r\njoin penulis ps \r\nON ps.idpenulis = b.penulis_idpenulis" +
                           $"\r\njoin penerbit pt\r\nON pt.idpenerbit = b.penerbit_idpenerbit";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        /*public static DataTable showByJenis()
        {
            string query;
        }

        public static DataTable showBySearch()
        {
            string query;
        }*/



        public static void create(m_Buku bukuBaru)
        {
            string query = $"INSERT INTO {table} (isbn, namabuku, sinopsis, thnterbit, jenisbuku_idjenis, stokbuku, penerbit_idpenerbit, penulis_id, posisirak " +
                            $"penulis_idpenulis, posisirak) VALUES (@isbn, @namabuku, @sinopsis, @tahunterbit, @jenisbuku, @stokbuku, @penerbit, @penulis, @posisirak)";
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
    }
}
