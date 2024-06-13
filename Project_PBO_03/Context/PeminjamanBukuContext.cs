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
    internal class PeminjamanBukuContext : DBconnection
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

        public static DataTable bookingUser(int iduser)
        {
            string query = $"select b.isbn, b.namabuku, pb.tglpengambilan " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where p.iduser = @iduser and pb.status_idstatus = 1 ";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value =  iduser},

            };
            DataTable dataBooking = queryExecutor(query, parameters);
            return dataBooking;
        }

        public static DataTable dipinjamUser(int iduser)
        {
            string query = $"select b.isbn, b.namabuku, pb.tglpengambilan, pb.tglpengembalian " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where p.iduser = @iduser and pb.status_idstatus = 2 ";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value =  iduser},

            };
            DataTable dataBooking = queryExecutor(query, parameters);
            return dataBooking;
        }

        public static DataTable riwayatUser(int iduser)
        {
            string query = $"select b.isbn, b.namabuku, pb.tglpengambilan, pb.tglpengembalian " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where p.iduser = @iduser and pb.status_idstatus = 3 ";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value =  iduser},

            };
            DataTable dataBooking = queryExecutor(query, parameters);
            return dataBooking;
        }


        public static DataTable booking()
        {
            string query =  $"select pb.idpeminjaman, p.iduser ,p.namauser, b.isbn, b.namabuku, pb.tglpengambilan, pb.tglpengembalian " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where pb.status_idstatus = 1 ";
            DataTable dataBooking = queryExecutor(query);
            return dataBooking;
        }

        public static DataTable Dipinjam()
        {
            string query = $"select pb.idpeminjaman, p.iduser ,p.namauser, b.isbn, b.namabuku, pb.tglpengambilan, pb.tglpengembalian " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where pb.status_idstatus = 2 ";
            DataTable dataBooking = queryExecutor(query);
            return dataBooking;
        }

        public static DataTable Riwayat()
        {
            string query = $"select pb.idpeminjaman, p.iduser ,p.namauser, b.isbn, b.namabuku, pb.tglpengambilan, pb.tglpengembalian " +
                            $"from peminjamanbuku pb join pengguna p " +
                            $"on p.iduser = pb.pengguna_iduser " +
                            $"join buku b " +
                            $"on b.isbn = pb.buku_isbn " +
                            $"where pb.status_idstatus = 3 ";
            DataTable dataBooking = queryExecutor(query);
            return dataBooking;
        }

        public static void ubahStatusDipinjam(int idpeminjaman, int iduser, string isbn)
        {
            string query =  $"update peminjamanbuku " +
                            $"set status_idstatus = 2 " +
                            $"where idpeminjaman = @idpeminjaman and pengguna_iduser = @iduser and buku_isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idpeminjaman", NpgsqlDbType.Integer) {Value = idpeminjaman},
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value = iduser},
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar) {Value = isbn}
            };
            commandExecutor(query, parameters);
        }

        public static void ubahStatusRiwayat(int idpeminjaman, int iduser, string isbn)
        {
            string query =  $"update peminjamanbuku " +
                            $"set status_idstatus = 3 " +
                            $"where idpeminjaman = @idpeminjaman and pengguna_iduser = @iduser and buku_isbn = @isbn";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idpeminjaman", NpgsqlDbType.Integer) {Value = idpeminjaman},
                new NpgsqlParameter("@iduser", NpgsqlDbType.Integer) {Value = iduser},
                new NpgsqlParameter("@isbn", NpgsqlDbType.Varchar) {Value = isbn}
            };
            commandExecutor(query, parameters);
        }
    }
}
