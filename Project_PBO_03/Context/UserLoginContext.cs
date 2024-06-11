using Npgsql;
using Project_PBO_03.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Context
{
    internal class UserLoginContext : DBconnection
    {
        public static DataTable getdatadirinama(string username)
        {
            string query = "SELECT iduser FROM profil WHERE usrnmeuser = @username";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@username", username) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }
    }
}
