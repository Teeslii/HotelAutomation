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
    public partial class newUserBooking : Form
    {
        
        public newUserBooking()
        {
            InitializeComponent();
           
        }


        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;


        
        private void txtExitDate_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                string insertUserInfo = "Insert INTO customer (firstName, lastName, telephone, mail,  TC, price, loginDate, exitDate, reservationType) values(@firstName, @lastName, @telephone, @mail, @TC, @price, @loginDate, @exitDate, @reservationType)";
                SqlCommand sqlCommand = new SqlCommand(insertUserInfo, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@firstName", SqlDbType.VarChar, 50) { Value = txtFirstName.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastName", SqlDbType.NVarChar, 50) { Value = txtLastName.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@telephone", SqlDbType.VarChar, 11) { Value = txtTelephone.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@mail", SqlDbType.NVarChar, 60) { Value = txtMail.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TC", SqlDbType.VarChar, 11) { Value = txtID.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", SqlDbType.Int) { Value = txtPrice.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@loginDate", SqlDbType.Date) { Value = txtLoginDate.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exitDate", SqlDbType.Date) { Value = txtExitDate.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@reservationType", SqlDbType.NVarChar, 70) { Value = cBoxChoose.SelectedItem.ToString() });

                sqlCommand.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Recorded.");
            }
             
        }


        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void cBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void newUserBooking_Load(object sender, EventArgs e)
        {
            roomControlBooking.ColorTransition();
        }
    }
}

