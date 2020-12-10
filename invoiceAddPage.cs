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
    public partial class invoiceAddPage : Form
    {
        public invoiceAddPage()
        {
            InitializeComponent();
        }
        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;

        public int room { get; set; }
        private void invoiceAddPage_Load(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string pushCustomerInfo = "select firstName, howmanyday, price, loginDate, exitDate from customer join Room on customer.ID= Room.ID where Room.roomNo=  @room  ";
                SqlCommand sqlCommand = new SqlCommand(pushCustomerInfo, connection);
                sqlCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@room", SqlDbType.Int, 3) { Value = room });
                sqlCommand.ExecuteNonQuery();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                
                    txtFirstName.Text= reader["firstName"].ToString();
                    txthowmanyday.Text= reader["howmanyday"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtLoginDate.Text= reader["loginDate"].ToString();
                    txtInvoiceDate.Text= reader["exitDate"].ToString();
                    txtRoom.Text = room.ToString();
                }
                reader.Close();

                string deleteOut = "delete from Room where roomNo= @room ";
                SqlCommand deletecommand = new SqlCommand(deleteOut, connection);
                deletecommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@room", SqlDbType.Int, 3) { Value = room });
                deletecommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();

        }
    }
}
