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

        public int RoomNo{  get;   set;  }
        public void ColorTransition()
        {
            foreach (RoomControl roomIsDelete in RoomControlService.QueryIsDelete())
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
     
        public int CustomerId { get; set; }
        
        private void Room1_Click(object sender, EventArgs e)
        {
           
            if (Room1.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(1, CustomerId);
                Room1.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(1);
                Room1.BackColor = Color.Lime;
            }
        }

        private void Room2_Click(object sender, EventArgs e)
        {
            if (Room2.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(2, CustomerId);
                Room2.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(2);
                Room2.BackColor = Color.Lime;
            }
        }

        private void Room3_Click(object sender, EventArgs e)
        {
            if (Room3.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(3, CustomerId);
                Room3.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(3);
                Room3.BackColor = Color.Lime;
            }
        }

        private void Room4_Click(object sender, EventArgs e)
        {

            if (Room4.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(4, CustomerId);
                Room4.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(4);
                Room4.BackColor = Color.Lime;
            }
        }

        private void Room5_Click(object sender, EventArgs e)
        {
            if (Room5.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(5, CustomerId);
                Room5.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(5);
                Room5.BackColor = Color.Lime;
            }
        }

        private void Room6_Click(object sender, EventArgs e)
        {
            if (Room6.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(6, CustomerId);
                Room6.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(6);
                Room6.BackColor = Color.Lime;
            }
        }

        private void Room7_Click(object sender, EventArgs e)
        {
            if (Room7.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(7, CustomerId);
                Room7.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(7);
                Room7.BackColor = Color.Lime;
            }
        }

        private void Room8_Click(object sender, EventArgs e)
        {
            if (Room8.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(8, CustomerId);
                Room8.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(8);
                Room8.BackColor = Color.Lime;
            }
        }

        private void Room9_Click(object sender, EventArgs e)
        {
            if (Room9.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(9, CustomerId);
                Room9.BackColor = Color.Salmon;
            }
            else
            {
                RoomControlService.DeleteRoom(9);
                Room9.BackColor = Color.Lime;
            }
        }
    }
}
