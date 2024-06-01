using Project_PBO_03.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Project_PBO_03.Context
{
    internal class BukuContext : DBconnection
    {
        private static string table = "buku";

        public static DataTable all()
        {
            string query = $"select * from {table}";
            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }

        /*public static DataTable show()
        {
            
        }*/
    }
}
