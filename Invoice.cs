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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
      
        SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString);
      
        private int RoomNoInvoice;
        private void cbFeePayable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFeePayable.SelectedIndex==0)
            {
                btnPaid.Visible = true;
                pnlCard.Visible = false;
            }
            else if (cbFeePayable.SelectedIndex==1)
            {
                pnlCard.Visible = true;
                btnPaid.Visible = false;
            }
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            RoomNoInvoice = Convert.ToInt32(txtResearchRoom.Text);
            connectionString.Open();
            SqlCommand roomFee = new SqlCommand("select price from customer join Room on customer.ID = Room.ID where Room.roomNo= @roomNo", CString);
            roomFee.Parameters.Add(new System.Data.SqlClient.SqlParameter("@roomNo", SqlDbType.Int, 5) { Value = RoomNoInvoice });
            roomFee.ExecuteNonQuery();
            SqlDataReader dataReader = roomFee.ExecuteReader();

            while(dataReader.Read())
            {
               TxtFeePayable.Text = dataReader["price"].ToString();
            }
            connectionString.Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            invoiceAddPage pageShow = new invoiceAddPage();
            pageShow.room = RoomNoInvoice;
            pageShow.Show();
            this.Hide();
        }

        private void btnCardPayment_Click(object sender, EventArgs e)
        {
            invoiceAddPage pageShow = new invoiceAddPage();
            pageShow.room = RoomNoInvoice;
            pageShow.Show();
            this.Hide();
        }
    }
}
