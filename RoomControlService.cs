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
        public static void AddingRoom(int _roomNo, Booking booking)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var getRoomIdQuery = "select RoomId from Room where RoomNo = @RoomNo ";
                var cmd = new SqlCommand(getRoomIdQuery, connection);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RoomNo", SqlDbType.Int) { Value = _roomNo });
                var saveRoomId = cmd.ExecuteScalar();
                if (!int.TryParse(saveRoomId.ToString(), out int _roomId))
                {
                    System.Windows.Forms.MessageBox.Show("An error occurred while retrieving the registered customer's ID.");
                }

                booking.RoomId = _roomId;

                var InsertBookingQuery = "Insert into Booking(CheckIn, CheckOut, RoomId, CustomerId) values(@CheckIn, @CheckOut, @RoomId, @CustomerId)";
                var cmdInsert = new SqlCommand(InsertBookingQuery, connection);
                cmdInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckIn", SqlDbType.Date) { Value = booking.CheckIn });
                cmdInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckOut", SqlDbType.Date) { Value = booking.CheckOut });
                cmdInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RoomId", SqlDbType.Int) { Value = booking.RoomId });
                cmdInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerId", SqlDbType.Int) { Value = booking.CustomerId });
                cmdInsert.ExecuteNonQuery();

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
                    if (!int.TryParse(readerQuery["RoomNo"].ToString(), out int _roomNo))
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
        public static Booking GetBasePrice(int _roomNo, Booking booking)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string BasePriceQuery = "select BasePrice, CheckIn, CheckOut From Room Join Booking on Room.RoomId = Booking.RoomId where  ((CheckIn <=  @CheckOut) and (CheckOut >= @CheckIn)) and RoomNo = @RoomNo";
                var cmd = new SqlCommand(BasePriceQuery, connection);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RoomNo", SqlDbType.Int) { Value = _roomNo });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckIn", SqlDbType.Date) { Value = booking.CheckIn });
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CheckOut", SqlDbType.Date) { Value = booking.CheckOut });

                SqlDataReader readerQuery = cmd.ExecuteReader();

                float _basePrice;

                while (readerQuery.Read())
                {
         
                    if (!DateTime.TryParse(readerQuery["CheckIn"].ToString(), out DateTime _checkIn))
                    {
                        System.Windows.Forms.MessageBox.Show("Data processing error has occurred when processing Check-In data.");
                    }
                    booking.CheckIn = _checkIn;

                    if (!DateTime.TryParse(readerQuery["CheckOut"].ToString(), out DateTime _checkOut))
                    {
                        System.Windows.Forms.MessageBox.Show("Data processing error has occurred when processing Check-Out data.");
                    }
                    booking.CheckOut = _checkOut;

                    if (!float.TryParse(readerQuery["BasePrice"].ToString(), out _basePrice))
                    {
                        System.Windows.Forms.MessageBox.Show("Data processing error has occurred when processing Check-Out data.");
                    }
                    booking = booking.AccountAmount(booking, _basePrice);
                }
                 
                readerQuery.Close();

                connection.Close();
               return booking;
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
