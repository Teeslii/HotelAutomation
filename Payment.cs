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
           if(card.NameSurname != null && card.NumberCard != null )
            {
                System.Windows.Forms.MessageBox.Show("Your payment transaction has been completed successfully.");
            }
           else
            {
                System.Windows.Forms.MessageBox.Show("Your payment transaction has failed.");
            }
       }
    }
}
