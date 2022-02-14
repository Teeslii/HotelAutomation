using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }

        public float Amount { get; set; }

        public Booking AccountAmount(Booking booking, float _basePrice)
        {
            Amount = 0;
            TimeSpan SumDay = booking.CheckOut - booking.CheckIn;
            if (!float.TryParse(SumDay.Days.ToString(), out float _sumDay))
            {
                System.Windows.Forms.MessageBox.Show("Data processing error has occurred when processing Check-In data.");
            }
            Amount = _sumDay * _basePrice;
            
            return booking;
        }
    }
}
