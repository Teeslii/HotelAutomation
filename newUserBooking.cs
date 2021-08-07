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
        IDataAcces dataAcces;
        public newUserBooking(IDataAcces dataAcces)
        {
            InitializeComponent();
            this.dataAcces = dataAcces;
        }


        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;


        
        private void txtExitDate_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
             
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

