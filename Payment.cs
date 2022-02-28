using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Payment : IPayment
    {
       public void VerificationCard(Card card)
       {
            card.NameSurname = card.NameSurname.Trim();
            card.NumberCard = card.NumberCard.Trim();
            card.Cvc = card.Cvc.Trim();

            
            if (string.IsNullOrEmpty(card.NameSurname))
              throw new ArgumentException("Holder Of Card:");
         
            else if(string.IsNullOrEmpty(card.NumberCard))
                throw new ArgumentException("Number Of Card:");

            else if(string.IsNullOrEmpty(card.Cvc))
                throw new ArgumentException("Valid Thru:");

            else
            {
                System.Windows.Forms.MessageBox.Show("Your payment transaction has been completed successfully.");
            }
       }
    }
}
