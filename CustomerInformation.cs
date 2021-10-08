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
using hotel.Models;

namespace hotel
{
    public partial class CustomerInformation : Form
    {
        private readonly IDataAccess _dataAccess;
        public CustomerInformation(IDataAccess _dataAccess)
        {
            InitializeComponent();
            this._dataAccess = _dataAccess;
        }

        private void AssignShowInfoList()
        {
            listCustomerInformation.Items.Clear();

            List<CustomerDto> customerDto;
            customerDto = _dataAccess.MapperShowInfo();

            foreach (CustomerDto getCustomersInfo in customerDto)
            {
                ListViewItem addItems = new ListViewItem();

                addItems.Text = getCustomersInfo.CustomerId.ToString();
                addItems.SubItems.Add(getCustomersInfo.NameSurname);
                addItems.SubItems.Add(getCustomersInfo.Telephone);
                addItems.SubItems.Add(getCustomersInfo.Mail);
                addItems.SubItems.Add(getCustomersInfo.Country);
                addItems.SubItems.Add(getCustomersInfo.Tc.ToString());
                addItems.SubItems.Add(getCustomersInfo.Address);

                listCustomerInformation.Items.Add(addItems);

            }
        }

         private void btnShowInformation_Click(object sender, EventArgs e)
        {
            AssignShowInfoList();
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

        Customer customer = new Customer();

        private void listCustomerInformation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            customer.CustomerId = int.Parse(listCustomerInformation.Items[e.Index].SubItems[0].Text);
            txtNameSurname.Text = listCustomerInformation.Items[e.Index].SubItems[1].Text;
            txtTelephone.Text = listCustomerInformation.Items[e.Index].SubItems[2].Text;
            txtMail.Text = listCustomerInformation.Items[e.Index].SubItems[3].Text;
            txtCountry.Text = listCustomerInformation.Items[e.Index].SubItems[4].Text;
            txtTc.Text = listCustomerInformation.Items[e.Index].SubItems[5].Text;
            txtAddress.Text = listCustomerInformation.Items[e.Index].SubItems[6].Text;
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

        
    }
}
