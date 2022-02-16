using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public interface IPayment
    {
        void VerificationCard(Card card);
    }
}
