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
        public static List<Room> GetFullRooms(Booking  booking)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                List<Room> ResultFullRooms = new List<Room>();

                string queryRoomsCheck = "select Room.RoomNo from Booking join Room on Booking.RoomId = Room.RoomId where (CheckIn <= @CheckOut) and (CheckOut >= @CheckIn)";

                SqlCommand cmd = new SqlCommand(queryRoomsCheck, connection);

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckIn", SqlDbType.Date) { Value = booking.CheckIn });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckOut", SqlDbType.Date) { Value = booking.CheckOut });

                SqlDataReader readerQuery = cmd.ExecuteReader();

                while (readerQuery.Read())
                {
                    if (!int.TryParse(readerQuery["roomNo"].ToString(), out int _roomNo))
                    {
                        System.Windows.Forms.MessageBox.Show("Data processing error has occurred when processing Room Number data.");
                    }
                    ResultFullRooms.Add(new Room() { RoomNo = _roomNo });
                }
                readerQuery.Close();
                connection.Close();
                return ResultFullRooms;

            }

        }

        public static void DeleteRoom(int _roomNo)
        {
            using (var connectionDelete = new SqlConnection(_connectionString))
            {
                connectionDelete.Open();

                string updateQuery = "update Room set IsDelete='True', checkOut=GETDATE() where roomNo = @_roomNo";
                SqlCommand delete = new SqlCommand(updateQuery, connectionDelete);
                delete.Parameters.Add(new System.Data.SqlClient.SqlParameter("@_roomNo", SqlDbType.Int) { Value = _roomNo });
                delete.ExecuteNonQuery();

                connectionDelete.Close();
            }
        }
    }
}
