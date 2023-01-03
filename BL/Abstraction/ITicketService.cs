using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstraction
{
    public interface ITicketService<T>
    {

        public void BuyTicket (T PlaceId, T PerfomanceId);
        public IEnumerable<Ticket<T>> GetAllTickets();

    }
}
