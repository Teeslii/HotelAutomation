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
    public partial class NewUserBooking : Form
    {
        public IDataAccess _dataAccess;
        public NewUserBooking(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }

        Customer customer = new Customer();


        private void SaveCustomerInfo()
        {
            customer.NameSurname = txtNameSurname.Text;
           
            customer.Telephone = txtTelephone.Text;
            
            customer.Mail = txtMail.Text;

            customer.Country = txtCountry.Text;

           if(!long.TryParse(txtTc.Text, out long Tc))
            {
                MessageBox.Show("An error occurred while entering TC. Please enter again your TC number.");
                return;
            }
            customer.Tc = Tc;

            customer.Address = txtAddress.Text;
            customer.CustomerId = _dataAccess.SaveCustomer(customer);

        }

      
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SaveCustomerInfo();
           CheckInOut checkInOut = new CheckInOut();
            checkInOut.TransferId(customer.CustomerId);
            checkInOut.Show();
            this.Hide();

        }


        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

      
        private void newUserBooking_Load(object sender, EventArgs e)
        {
            roomControlBooking.DefaultColor();
        }

        
    }
}

