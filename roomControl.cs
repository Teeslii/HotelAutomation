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

        private int _roomNo;
        public int RoomNo
        {
            get
            {
                return _roomNo;
            }
            set
            {
                _roomNo = value;
            }
        }
        public void ColorTransition()
        {
            foreach (roomControl roomIsDelete in RoomControlService.UpdateColor())
            {
               switch(roomIsDelete._roomNo)
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
        private int _convertID()
        {
            int.TryParse(txtCustomerID.Text, out int customerID);
            return customerID;
        }
        private void Room1_Click(object sender, EventArgs e)
        {
           
            if (Room1.BackColor == Color.Lime)
            {
                RoomControlService.AddingRoom(1, _convertID());
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
                RoomControlService.AddingRoom(2, _convertID());
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
                RoomControlService.AddingRoom(3, _convertID());
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
                RoomControlService.AddingRoom(4, _convertID());
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
                RoomControlService.AddingRoom(5, _convertID());
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
                RoomControlService.AddingRoom(6, _convertID());
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
                RoomControlService.AddingRoom(7, _convertID());
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
                RoomControlService.AddingRoom(8, _convertID());
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
                RoomControlService.AddingRoom(9, _convertID());
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
