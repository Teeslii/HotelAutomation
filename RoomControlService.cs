using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hotel
{
    public static class RoomControlService
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;
        public static void AddingRoom(int RoomNo, int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            }
        }
        
    }
}
