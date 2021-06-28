using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
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
        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;

        private int convertID;
       
        private void btnResearch_Click(object sender, EventArgs e)
        {
            convertID = Convert.ToInt32(txtResearchRoom.Text);

            using (var connection = new SqlConnection(ConnectionString))
            {  
                connection.Open();
                string ResearchChart = " select firstName, lastName, telephone, price, howManyDay, Room.roomNo from customer inner join Room  on customer.ID = Room.ID where Room.roomNo= @convertID ";
                SqlCommand sqlCommand = new SqlCommand(ResearchChart, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@convertID", SqlDbType.Int, 3) { Value = convertID });
                sqlCommand.ExecuteNonQuery();
                SqlDataReader readerInOut =  sqlCommand.ExecuteReader();
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
                connection.Close();
            }
             
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

         

        
    }
}
