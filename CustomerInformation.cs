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

        private void btnShowData_Click(object sender, EventArgs e)
        {
           

        }

        private int id = 0;
        private void listShowdata_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listShowdata.SelectedItems[0].SubItems[0].Text);
            txtLastName.Text  = listShowdata.SelectedItems[0].SubItems[2].Text;
            txtTelephone.Text = listShowdata.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listShowdata.SelectedItems[0].SubItems[4].Text;
            txtID.Text = listShowdata.SelectedItems[0].SubItems[5].Text;
           
            
        }
       
     

        private void btnClear_Click(object sender, EventArgs e)
        {
         
            txtLastName.Clear();
            txtTelephone.Clear();
            txtMail.Clear();
            txtID.Clear();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
          
        }
           
        
        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
