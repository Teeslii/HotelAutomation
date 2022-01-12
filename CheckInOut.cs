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
        

        public void TransferId(int SaveCustomerId)
        {
            roomControlCheck.CustomerId = SaveCustomerId;
        }
       
       
       

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

         

        
    }
}
