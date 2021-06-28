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

        private string color;
        private int RoomNo;

        private void colorUpdate()
        { 
            /*
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                Color myColor = Color.Salmon;

                SqlCommand command = new SqlCommand("select roomColor, roomNo from Room  ", connection);
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    
                    color = reader["roomColor"].ToString();

                    if (!int.TryParse(reader["roomNo"].ToString(), out RoomNo))
                    {
                        MessageBox.Show("Data processing error has occurred.");
                    }




                    myColor = Color.FromName(color);   
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
            }*/
        }
       
        private void delete (int idNumber )
        { /*
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
             
             
                    string UpdateQuery = "update Room set IsDelete='True' where roomNo = @idNumber ";
                    SqlCommand sqlCommand = new SqlCommand(UpdateQuery, connection);
                    sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@idNumber", SqlDbType.Int) { Value = idNumber });
                    sqlCommand.ExecuteNonQuery();
            
              

                connection.Close();

            }*/
        }
        private void roomControl_Load(object sender, EventArgs e)
        {
            colorUpdate();  
        }
        private int _convertID()
        {
            int.TryParse(txtCustomerID.Text, out int customerID);
            return customerID;
        }
        private void Room1_Click(object sender, EventArgs e)
        {
            RoomControlService.AddingRoom(1, _convertID());
            if (Room1.BackColor == Color.Lime)
            {
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
