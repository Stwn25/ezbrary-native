using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Core;
using Project_PBO_03.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Context
{
    internal class BukuFavoritContext: DBconnection
    {
        private static string table = "bukufavorit";

        public static DataTable read(string isbn, int id)
        {
            string query = $"SELECT * FROM {table} WHERE buku_isbn = @isbn AND pengguna_iduser = @iduser ";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@isbn", NpgsqlDbType.Varchar){Value = isbn},
                new NpgsqlParameter ("@iduser", NpgsqlDbType.Integer){Value = id}
            };
            DataTable dataFavorite = queryExecutor(query, parameters);
            return dataFavorite;
        }

        public static DataTable all(int id)
        {
            string query = $"select b.isbn, b.namabuku, jb.namajenis, b.stokbuku, b.posisirak" +
                           $"\r\nfrom bukufavorit bf" +
                           $"\r\njoin buku b \r\nON b.isbn = bf.buku_isbn" +
                           $"\r\njoin jenisbuku jb \r\nON jb.idjenis = b.jenisbuku_idjenis " +
                           $"where bf.pengguna_iduser = @iduser and bf.statusfavorit_idstatusfavorit = 1";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@iduser", NpgsqlDbType.Integer){Value = id}
            };
            DataTable dataBukuFavorit = queryExecutor(query, parameters);
            return dataBukuFavorit;
        }


        public static void tambahBukuFavorit(m_BukuFavorit bukufavorite)
        {
            string query = $"INSERT INTO {table} (buku_isbn, pengguna_iduser, statusfavorit_idstatusfavorit) " +
                            $"VALUES (@isbn, @iduser, @status)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@isbn", NpgsqlDbType.Varchar){Value = bukufavorite.isbn_buku},
                new NpgsqlParameter ("@iduser", NpgsqlDbType.Integer){Value=bukufavorite.id_pengguna},
                new NpgsqlParameter ("@status", NpgsqlDbType.Integer){Value = 1}


            };
            commandExecutor(query, parameters);
        }

        public static void deleteBukuFavorit(string isbn, int idpengguna)
        {
            string query = $"DELETE FROM {table} WHERE buku_isbn = @isbn and pengguna_iduser = @iduser";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = isbn},
                new NpgsqlParameter("iduser", NpgsqlDbType.Integer){ Value = idpengguna},
            };
            commandExecutor(query, parameters);
        }
    }
}
