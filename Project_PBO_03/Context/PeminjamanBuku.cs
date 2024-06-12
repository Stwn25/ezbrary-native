using Microsoft.VisualBasic.Logging;
using Npgsql;
using NpgsqlTypes;
using Project_PBO_03.Core;
using Project_PBO_03.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Context
{
    internal class PeminjamanBuku : DBconnection
    {
        public static void create(m_PeminjamanBuku peminjamanBaru)
        {
            string query =  $"INSERT INTO peminjamanbuku (tglpengambilan, tglpengembalian, buku_isbn, pengguna_iduser, status_idstatus) " +
                            $"VALUES (@tglambil, @tglkembali, @isbn, @iduser, @idstatus)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tglambil", NpgsqlDbType.Date){Value = peminjamanBaru.tgl_pengambilan},
                new NpgsqlParameter("@tglkembali", NpgsqlDbType.Date){Value = peminjamanBaru.tgl_pengembalian},
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar){Value = peminjamanBaru.isbn_buku},
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer){Value = peminjamanBaru.id_pengguna},
                new NpgsqlParameter("@idstatus", NpgsqlDbType.Integer){Value = peminjamanBaru.id_status}
            };
            commandExecutor(query, parameters);
        }

    }
}
