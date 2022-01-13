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
    public partial class RoomControl : UserControl
    {
        public RoomControl()
        {
            InitializeComponent();
        }

        public void DefaultColor()
        {
            Room1.BackColor = Color.Transparent;
            Room2.BackColor = Color.Transparent;
            Room3.BackColor = Color.Transparent;
            Room4.BackColor = Color.Transparent;
            Room5.BackColor = Color.Transparent;
            Room6.BackColor = Color.Transparent;
            Room7.BackColor = Color.Transparent;
            Room8.BackColor = Color.Transparent;
            Room9.BackColor = Color.Transparent;
        }

         
        public void ColorTransition(Booking booking)
        {
            foreach (Room roomIsDelete in RoomControlService.GetFullRooms(booking))
            {
                switch (roomIsDelete.RoomNo)
                {
                    case 1:
                        Room1.BackColor = Color.Salmon;
                        break;
                    case 2:
                        Room2.BackColor = Color.Salmon;
                        break;
                    case 3:
                        Room3.BackColor = Color.Salmon;
                        break;
                    case 4:
                        Room4.BackColor = Color.Salmon;
                        break;
                    case 5:
                        Room5.BackColor = Color.Salmon;
                        break;
                    case 6:
                        Room6.BackColor = Color.Salmon;
                        break;
                    case 7:
                        Room7.BackColor = Color.Salmon;
                        break;
                    case 8:
                        Room8.BackColor = Color.Salmon;
                        break;
                    case 9:
                        Room9.BackColor = Color.Salmon;
                        break;
                    default:
                        MessageBox.Show("No data matching the room number was found");
                        break;
                }
            }

        }
     
         
        
        private void Room1_Click(object sender, EventArgs e)
        {
            
        }

        private void Room2_Click(object sender, EventArgs e)
        {
            
        }

        private void Room3_Click(object sender, EventArgs e)
        {
            
        }

        private void Room4_Click(object sender, EventArgs e)
        {

            
        }

        private void Room5_Click(object sender, EventArgs e)
        {
            
        }

        private void Room6_Click(object sender, EventArgs e)
        {
             
        }

        private void Room7_Click(object sender, EventArgs e)
        {
             
        }

        private void Room8_Click(object sender, EventArgs e)
        {
             
        }

        private void Room9_Click(object sender, EventArgs e)
        {
             
        }
    }
}
