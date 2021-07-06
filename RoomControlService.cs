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
                string insertRoom = "Insert into Room(ID, roomNo, checkIn, IsDelete) values ( @ID, @roomNo, GETDATE(), 'False')";
                SqlCommand Insert = new SqlCommand(insertRoom, connection);
                Insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", SqlDbType.Int) { Value = ID });
                Insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@roomNo", SqlDbType.Int) { Value = RoomNo });
                Insert.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static string ErrorMessage;
        public static List<roomControl> UpdateColor()
        {
            using (var connectionIsDelete = new SqlConnection(_connectionString))
            {
                connectionIsDelete.Open();

                List<roomControl> isDeleteRead = new List<roomControl>();
                string queryIsDelete = "select roomNo from Room where IsDelete= 'False'";
                SqlCommand query = new SqlCommand(queryIsDelete, connectionIsDelete);
                SqlDataReader readerQuery = query.ExecuteReader();
                while (readerQuery.Read())
                {
                    if (!int.TryParse(readerQuery["roomNo"].ToString(), out int roomNo))
                    {
                        ErrorMessage = "Data processing error has occurred when processing Room Number data.";
                        System.Windows.Forms.MessageBox.Show(ErrorMessage);
                    }
                    isDeleteRead.Add(new roomControl() { RoomNo = roomNo });
                }
                readerQuery.Close();
                connectionIsDelete.Close();
                return isDeleteRead;

            }

        }

        public static void DeleteRoom(int _roomNo)
        {
            using (var connectionDelete = new SqlConnection(_connectionString))
            {
                connectionDelete.Open();

                string deleteQuery = "update Room set IsDelete='True', checkOut=GETDATE() where roomNo = @_roomNo";
                SqlCommand delete = new SqlCommand(deleteQuery, connectionDelete);
                delete.Parameters.Add(new System.Data.SqlClient.SqlParameter("@_roomNo", SqlDbType.Int) { Value = _roomNo });
                delete.ExecuteNonQuery();

                connectionDelete.Close();
            }
        }
    }
}
