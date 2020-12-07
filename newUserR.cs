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
    public partial class newUserR : Form
    {
        
        public newUserR()
        {
            InitializeComponent();
        }


        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;


        public int DayMany;
        private void txtExitDate_ValueChanged(object sender, EventArgs e)
        {
           
            int price;
           
            DateTime loginDate = Convert.ToDateTime(txtLoginDate.Text);
            DateTime exitDate = Convert.ToDateTime(txtExitDate.Text);

            TimeSpan result = exitDate - loginDate;
            DayMany = Convert.ToInt32(result.TotalDays);
            price = DayMany * 50;
            txtPrice.Text = price.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                string insertUserInfo = "Insert INTO customer (firstName, lastName, telephone, mail,  TC, price) values(@firstName, @lastName, @telephone, @mail, @TC, @price)";
                SqlCommand sqlCommand = new SqlCommand(insertUserInfo, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@firstName", SqlDbType.VarChar, 50) { Value = txtFirstName.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastName", SqlDbType.NVarChar, 50) { Value = txtLastName.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@telephone", SqlDbType.VarChar, 11) { Value = txtTelephone.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@mail", SqlDbType.NVarChar, 60) { Value = txtMail.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TC", SqlDbType.VarChar, 11) { Value = txtID.Text });
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@price", SqlDbType.Int) { Value = txtPrice.Text });


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
            if ( cBoxChoose.SelectedIndex == 0)
            {
               MessageBox.Show("The full fee is paid before the last 90 days.\n 75 % of the base price is paid.\n There is no refund. \n Change on the day of reservation takes place with an additional fee.\n The additional fee is 110 % of the base price.");
            }
            else if (cBoxChoose.SelectedIndex == 1)
            {
                MessageBox.Show("We will e-mail 45 days prior to payment.\nPayment is made 15 days before booking.\nIf payment is not made, the reservation will be canceled.\nIt pays 85 % of the base price.\nThere is no refund.\nChange on the day of reservation takes place with an additional fee. \nThe surcharge price is 110 % of the base price.\nIf it is lower than the old wage, the remaining amount is not paid.\n");
            }
            else if (cBoxChoose.SelectedIndex ==2)
            {
                MessageBox.Show(" The reservation can be made at any time. \n And it can be changed at any time. \n Payment is made at the end of the stay. \n You must enter your credit card number when booking. \n If there is less than 3 days left, the reservation will be canceled. \n And if you do not arrive on the first day of stay, the penalty the price is deducted from the card.");
            }
            else if (cBoxChoose.SelectedIndex == 3)
            {
                MessageBox.Show("For a reservation made more than 30 days before the start of the stay; If the expected average occupancy is 60 % or less, the price is paid 20 % lower.\nFOR EXAMPLE,\nGet a reservation for 4 nights after 25 days from Sunday to Thursday.\nThe average number of rooms kept for these 4 nights at that time is 22.5, and the expected average job rate is 50 %.\nThe price for 4 nights is 80 % of the base price.\nFee is paid at the end of the stay.\nCancellation and change of days(standard(classic) reservation). ");
            }
        }
    }
}

