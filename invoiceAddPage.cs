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
    public partial class invoiceAddPage : Form
    {
        public invoiceAddPage()
        {
            InitializeComponent();
        }
        SqlConnection linkedd = new SqlConnection("Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True");

        public int room { get; set; }
        private void invoiceAddPage_Load(object sender, EventArgs e)
        {
            linkedd.Open();
            SqlCommand pushIt = new SqlCommand("select firstName, howmanyday, price, loginDate, exitDate from customer join Room on customer.ID= Room.ID where Room.roomNo=(" +room + ")", linkedd);

            SqlDataReader reader = pushIt.ExecuteReader();
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
            SqlCommand deleteOut = new SqlCommand("delete from Room where roomNo=("+room+")",linkedd);
            deleteOut.ExecuteNonQuery();
            linkedd.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();

        }
    }
}
