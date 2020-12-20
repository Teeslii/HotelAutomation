using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;


namespace hotel
{
    public partial class roomControl : UserControl
    {
        public roomControl()
        {
            InitializeComponent();
        }

        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;
      
        private int convertID ;
        private TimeSpan sumDay;
        private void addingRoom(int number)
        {
            convertID = Convert.ToInt32(txtResearchRoom.Text);
            using (var connection = new SqlConnection(ConnectionString))
            {
               
                connection.Open();
                DateTime loginDate;
                DateTime exitDate;

                string timeQuery = "select  loginDate, exitDate from customer where  ID = @ID ";
                SqlCommand sqlCommand = new SqlCommand(timeQuery, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", SqlDbType.Int ) { Value = convertID });
                

                SqlDataReader read = sqlCommand.ExecuteReader();

                while (read.Read())
                {
                    loginDate = Convert.ToDateTime(read["loginDate"]);
                    exitDate = Convert.ToDateTime(read["exitDate"]);

                    sumDay = exitDate - loginDate;

                }

                read.Close();
                connection.Close();
               
                connection.Open();
             

                string insertRoom = "Insert into Room(ID, roomNo, roomColor, howManyDay, checkIn) values ( @ID, @number, 'Salmon', @howManyDay, GETDATE())";
                SqlCommand sqlCommandInsert = new SqlCommand(insertRoom, connection);
                sqlCommandInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", SqlDbType.Int) { Value = convertID });
                sqlCommandInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@number", SqlDbType.Int) { Value = number });
                sqlCommandInsert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@howManyDay", SqlDbType.Int) { Value = sumDay.TotalDays });

                sqlCommandInsert.ExecuteNonQuery();
                
                connection.Close();
            }
        }

        private string renk;
        private int RoomNo;

        private void colorUpdate()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                Color myColor = Color.Salmon;

                SqlCommand command = new SqlCommand("select roomColor, roomNo from Room  ", connection);
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    renk = reader["roomColor"].ToString();
                    RoomNo = Convert.ToInt32(reader["roomNo"]);

                    myColor = Color.FromName(renk);   
                    if (RoomNo == 1)
                    {
                        Room1.BackColor = myColor;
                    }
                    else if (RoomNo == 2)
                    {
                        Room2.BackColor = myColor;
                    }
                    else if (RoomNo == 3)
                    {
                        Room3.BackColor = myColor;
                    }
                    else if (RoomNo == 4)
                    {
                        Room4.BackColor = myColor;
                    }
                    else if (RoomNo == 5)
                    {
                        Room5.BackColor = myColor;
                    }
                    else if (RoomNo == 6)
                    {
                        Room6.BackColor = myColor;
                    }
                    else if (RoomNo == 7)
                    {
                        Room7.BackColor = myColor;
                    }
                    else if (RoomNo == 8)
                    {
                        Room8.BackColor = myColor;
                    }
                    else if (RoomNo == 9)
                    {
                        Room9.BackColor = myColor;
                    }

                }
                reader.Close();
                connection.Close();
            }
        }

        private void delete (int idNumber )
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
               
                string DeleteQuery = "delete roomColor, roomNo, howManyDay, checkIn, checkOut, ID from Room where ID = idNumber ";
                SqlCommand sqlCommand = new SqlCommand(DeleteQuery, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@idNumber", SqlDbType.Int) { Value = idNumber });
                sqlCommand.ExecuteNonQuery();

                connection.Close();

            }
        }
        private void roomControl_Load(object sender, EventArgs e)
        {
            colorUpdate();  
        }

        private void Room1_Click(object sender, EventArgs e)
        {
            if (Room1.BackColor == Color.Lime)
            {
                addingRoom(1);
                Room1.BackColor = Color.Salmon;
            }
            else
            {
                delete(1);
                Room1.BackColor = Color.Lime;
            }
        }

        private void Room2_Click(object sender, EventArgs e)
        {
            if (Room2.BackColor == Color.Lime)
            {
                addingRoom(2);
                Room2.BackColor = Color.Salmon;
            }
            else
            {
                delete(2);
                Room2.BackColor = Color.Lime;
            }
        }

        private void Room3_Click(object sender, EventArgs e)
        {
            if (Room3.BackColor == Color.Lime)
            {
                addingRoom(3);
                Room3.BackColor = Color.Salmon;
            }
            else
            {
                delete(3);
                Room3.BackColor = Color.Lime;
            }
        }

        private void Room4_Click(object sender, EventArgs e)
        {

            if (Room4.BackColor == Color.Lime)
            {
                addingRoom(4);
                Room4.BackColor = Color.Salmon;
            }
            else
            {
                delete(4);
                Room4.BackColor = Color.Lime;
            }
        }

        private void Room5_Click(object sender, EventArgs e)
        {
            if (Room5.BackColor == Color.Lime)
            {
                addingRoom(5);
                Room5.BackColor = Color.Salmon;
            }
            else
            {
                delete(5);
                Room5.BackColor = Color.Lime;
            }
        }

        private void Room6_Click(object sender, EventArgs e)
        {
            if (Room6.BackColor == Color.Lime)
            {
                addingRoom(6);
                Room6.BackColor = Color.Salmon;
            }
            else
            {
                delete(6);
                Room6.BackColor = Color.Lime;
            }
        }

        private void Room7_Click(object sender, EventArgs e)
        {
            if (Room7.BackColor == Color.Lime)
            {
                addingRoom(7);
                Room7.BackColor = Color.Salmon;
            }
            else
            {
                delete(7);
                Room7.BackColor = Color.Lime;
            }
        }

        private void Room8_Click(object sender, EventArgs e)
        {
            if (Room8.BackColor == Color.Lime)
            {
                addingRoom(8);
                Room8.BackColor = Color.Salmon;
            }
            else
            {
                delete(8);
                Room8.BackColor = Color.Lime;
            }
        }

        private void Room9_Click(object sender, EventArgs e)
        {
            if (Room9.BackColor == Color.Lime)
            {
                addingRoom(9);
                Room9.BackColor = Color.Salmon;
            }
            else
            {
                delete(9);
                Room9.BackColor = Color.Lime;
            }
        }
    }
}
