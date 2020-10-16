using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        SqlConnection connectn = new SqlConnection("Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True");
        //Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True
       
        private int convertID ;
       
       
        private string price;
        
        private void aadd(int number)
        {
          
           
            
            convertID = Convert.ToInt32(txtResearchRoom.Text);
            connectn.Open();
            SqlCommand commandd = new SqlCommand(" select  price from customer where  ID = (" + convertID + ")", connectn);
            commandd.ExecuteNonQuery();
            SqlDataReader read = commandd.ExecuteReader();
           
            while (read.Read())
            {
               
                price = read["price"].ToString();
           }
           
            read.Close();
            connectn.Close();
            int howmanyday = 0;
             int numb= 0;
           
            numb = Convert.ToInt32(price);
            howmanyday = (numb/50);
           connectn.Open(); 
           SqlCommand insert = new SqlCommand("Insert into Room(ID, roomNo, roomColor, howManyDay, checkIn) values ('" + convertID + "','" + number + "', 'Salmon','" + howmanyday + "', GETDATE() )", connectn);
           insert.ExecuteNonQuery();
           connectn.Close();
        }

        private string renk;
        private int RoomNo;

        private void Colorupdate()
        {
            connectn.Open();
            Color myColor = Color.Salmon;

            SqlCommand command = new SqlCommand("select roomColor, roomNo from Room  ", connectn);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                renk = reader["roomColor"].ToString();
                RoomNo = Convert.ToInt32(reader["roomNo"]);

                myColor = Color.FromName(renk);  // string değeri color'a çevirme
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
            connectn.Close();
        }

        private void delete (int Dnumber )
        {
            connectn.Open();
            SqlCommand sqlDelete = new SqlCommand("delete * from Room where ID =("+ Dnumber +")",connectn);

            connectn.Close();
        }
        private void roomControl_Load(object sender, EventArgs e)
        {
            Colorupdate();  // Açıldığı an renkleri veritabanından yüklesin.
        }

        private void Room1_Click(object sender, EventArgs e)
        {
            if (Room1.BackColor == Color.Lime)
            {
                aadd(1);
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
                aadd(2);
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
                aadd(3);
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
                aadd(4);
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
                aadd(5);
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
                aadd(6);
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
                aadd(7);
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
                aadd(8);
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
                aadd(9);
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
