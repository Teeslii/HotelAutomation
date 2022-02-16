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
        private readonly IPayment _payment;
        public Invoice(IPayment _payment)
        {
            InitializeComponent();
            this._payment = _payment;
        }

        public void WriteSumAmount(Booking booking)
        {
            lblPaymentAmountText.Text = booking.Amount.ToString();
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

       
        
        public void GetCardInfo()
        {
            Card card = new Card();

            card.NameSurname = txtNameOfCard.Text;
            card.NumberCard = txtCardPart1.Text + txtCardPart2.Text + txtCardPart3.Text + txtCardPart4.Text;

            
                if (!int.TryParse(txtMMNumber.Text, out int _month))
                {
                    MessageBox.Show("An error occurred while entering month . Please enter again your month .");
                    return;
                }
                card.Month = _month;

                if (!int.TryParse(txtYYNumber.Text, out int _year))
                {
                    MessageBox.Show("An error occurred while entering year. Please enter again your year.");
                    return;
                }
                card.Year = _year;
 

                if (!int.TryParse(txtCVCNumber.Text, out int _Cvc))
                {
                    MessageBox.Show("An error occurred while entering CVC. Please enter again your CVC.");
                    return;
                }
                card.Cvc = _Cvc;
            _payment.VerificationCard(card);
        }

        private void btnCardPayment_Click(object sender, EventArgs e)
        {

            GetCardInfo();
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment transaction has been completed successfully.");
        }
    }
}