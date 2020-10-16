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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        SqlConnection linkedd = new SqlConnection("Data Source=LAPTOP-VBIOM4D2;Initial Catalog=Octopus;Integrated Security=True");

        public int RoomNoInvoice;
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
            linkedd.Open();
            SqlCommand roomFee = new SqlCommand("select price from customer join Room on customer.ID= Room.ID where Room.roomNo=("+RoomNoInvoice +")", linkedd);
            roomFee.ExecuteNonQuery();
            SqlDataReader dataReader = roomFee.ExecuteReader();

            while(dataReader.Read())
            {
               TxtFeePayable.Text = dataReader["price"].ToString();
            }
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
