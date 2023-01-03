using DAL.Entites;
using System.Collections.Generic;

namespace DAL.Repositories.Abstraction
{
    public interface ITicketRepository : IRepository<TicketEntity, int>
    {

        public bool CheckIfTicketExist(int PlaceId, int PerfomanceId);

        public IEnumerable<int> GetAllBusyPlacesFromTickets(int PerfomanceId);




    }
}
