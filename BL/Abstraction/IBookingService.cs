using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstraction
{
    public interface IBookingService<T>
    {
        public void BookTicket(T PlaceId, T PerfomanceId);

        public void SellBookedTicket(T PlaceId, T PerfomanceId);

        public IEnumerable<Booking<T>> GetAllBookings();
    }
}
