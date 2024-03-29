﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class MainPage : Form
    {
        private readonly IDataAccess _dataAccess;
        public MainPage()
        {
            InitializeComponent();
            _dataAccess = (IDataAccess)Program.ServiceProvider.GetService(typeof(IDataAccess));
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnNewUser_Reservation_Click(object sender, EventArgs e)
        {
            NewUserBooking newUserBooking = new NewUserBooking(_dataAccess);
            newUserBooking.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckInOut checkInOut = new CheckInOut();
            checkInOut.Show();
            this.Hide();
        }

     

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            
            CustomerInformation customers = new CustomerInformation(_dataAccess);
            
            customers.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }
    }
}
