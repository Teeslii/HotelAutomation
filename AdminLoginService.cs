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
   public static class AdminLoginService
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;

       

        public static bool VerificationUser(string _convertedPassword, string _userName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
         
                bool _resultVerication;
                var verificationQuery = "SELECT Password from Employee where UserName = @UserName";
                var cmd = new SqlCommand(verificationQuery, connection);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", SqlDbType.NVarChar, 150) { Value = _userName});

                var _savedPassword = cmd.ExecuteScalar();


                if (_convertedPassword == _savedPassword.ToString())
                {
                    _resultVerication = true;
                }
                else
                {
                    _resultVerication = false;
                }
                return _resultVerication;

                connection.Close();
            }
        }
    }
}
