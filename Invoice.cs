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
 

namespace hotel
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
      
         
       
        private void cbFeePayable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFeePayable.SelectedIndex==0)
            {
                btnCashPayment.Visible = true;
                pnlCard.Visible = false;
            }
            else if (cbFeePayable.SelectedIndex==1)
            {
                pnlCard.Visible = true;
                btnCashPayment.Visible = false;
            }
        }

        private void btnhomeback_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCardPayment_Click(object sender, EventArgs e)
        {
            
        }
    }
}
