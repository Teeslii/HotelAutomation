using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hotel
{
    public partial class CheckInOut : Form
    {
        public CheckInOut()
        {
            InitializeComponent();
        }
        SqlConnection connectin = new SqlConnection("Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True");

        public int convertID;
       
        private void btnResearch_Click(object sender, EventArgs e)
        {
              convertID = Convert.ToInt32(txtResearchRoom.Text);

            connectin.Open();
            SqlCommand commandd = new SqlCommand(" select firstName, lastName, telephone, price, howManyDay, Room.roomNo from customer inner join Room  on customer.ID = Room.ID where Room.roomNo=(" + convertID + ")", connectin);
            
            SqlDataReader readerInOut = commandd.ExecuteReader();
             while (readerInOut.Read())
            {
                txtFirstName.Text = readerInOut["firstName"].ToString();
                txtLastName.Text = readerInOut["lastName"].ToString();
                txtTelephone.Text = readerInOut["telephone"].ToString();

                txtPrice.Text = readerInOut["price"].ToString();
                txthowManyDay.Text = readerInOut["howManyDay"].ToString();
                txtRoomNo.Text = readerInOut["roomNo"].ToString();
            }
            readerInOut.Close();
            connectin.Close();
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

         

        
    }
}
