using System;
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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void btnHomeBack_Click(object sender, EventArgs e)
        { 
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
        }

        // take lblAboutUs text https://crimsonhotel.com/mactan/about-us

    }
}
