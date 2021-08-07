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
using AutoMapper;
using hotel.Models;

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

        Customer customer = new Customer();

        private string ConnectionString = ConfigurationManager.ConnectionStrings["hotel.Properties.Settings.Setting"].ConnectionString;

        private void MapperCustomerDto()
        {
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            long.TryParse(txtTelephone.Text, out long Telephone);
            customer.Telephone = Telephone;
            customer.Mail = txtMail.Text;
            long.TryParse(txtID.Text, out long ID);
            customer.TC = ID;
            int.TryParse(txtPrice.Text, out int Price);
            customer.Price = Price;
            DateTime.TryParse(txtLoginDate.Text, out DateTime LoginDate);
            customer.LoginDate = LoginDate;
            DateTime.TryParse(txtExitDate.Text, out DateTime ExitDate);
            customer.ExitDate = ExitDate;
            customer.ReservationType = cBoxChoose.SelectedItem.ToString();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer,CustomerDto>());
            var mapper = new Mapper(config);
            var customerDto = mapper.Map<CustomerDto>(customer);
            

        }

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

