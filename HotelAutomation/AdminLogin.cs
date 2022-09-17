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
            Staff staff = new Staff();
             staff.UserName = userNameTxt.Text.Trim();
             staff.Password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(staff.UserName))
                throw new ArgumentException("User Name: ");

            if (string.IsNullOrEmpty(staff.Password))
                throw new ArgumentException("Password: ");

            SHA1 sha = new SHA1CryptoServiceProvider();

            byte[] bytes  = sha.ComputeHash(Encoding.UTF8.GetBytes(staff.Password));

            StringBuilder builder = new StringBuilder();
            foreach(var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            bool ResultVerification = AdminLoginService.VerificationUser(builder.ToString(), staff.UserName);

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
