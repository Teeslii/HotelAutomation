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
    public partial class CustomerInformation : Form
    {
       
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void showdata()
        {
           
        }

       

        private int id = 0;
        private void listCustomerInformation_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listCustomerInformation.SelectedItems[0].SubItems[0].Text);
            txtNameSurname.Text  = listCustomerInformation.SelectedItems[0].SubItems[1].Text;
            txtTelephone.Text = listCustomerInformation.SelectedItems[0].SubItems[2].Text;
            txtMail.Text = listCustomerInformation.SelectedItems[0].SubItems[3].Text;
            txtCountry.Text = listCustomerInformation.SelectedItems[0].SubItems[4].Text;
            txtTc.Text = listCustomerInformation.SelectedItems[0].SubItems[5].Text;
            txtAddress.Text = listCustomerInformation.SelectedItems[0].SubItems[6].Text;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
         
            txtNameSurname.Clear();
            txtTelephone.Clear();
            txtMail.Clear();
            txtCountry.Clear();
            txtTc.Clear();
            txtAddress.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
          
        }
           
        
        private void btnHomeBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void btnShowInformation_Click(object sender, EventArgs e)
        {

        }

       
    }
}
