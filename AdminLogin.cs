using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace hotel
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        public void VerifyUserLogin()
        {
            string _userName = userNameTxt.Text.Trim();
            string _password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userNameTxt.Text))
                throw new ArgumentException("User Name: ");

            if (string.IsNullOrEmpty(txtPassword.Text))
                throw new ArgumentException("Password: ");

            SHA1 sha = new SHA1CryptoServiceProvider();

            byte[] bytes  = sha.ComputeHash(Encoding.UTF8.GetBytes(_password));

            StringBuilder builder = new StringBuilder();
            foreach(var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            bool ResultVerification = AdminLoginService.VerificationUser(builder.ToString(), _userName);

            if (ResultVerification == true)
            {
                MessageBox.Show("Successfully logged in.");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Failed to login.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerifyUserLogin();
          
        }
    }
}
