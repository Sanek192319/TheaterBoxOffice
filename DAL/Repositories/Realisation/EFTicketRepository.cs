using DAL.Entites;
using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realisation
{
    public class EFTicketRepository : EFGenericRepository<TicketEntity, int>, ITicketRepository
    {
        public EFTicketRepository(TheaterBoxOfficeDbContext dbContext) : base(dbContext, dbContext.Tickets)
        {

        }

        public void BookTicket(int PlaceId, int PerfomanceId)
        {
            throw new NotImplementedException();
        }

        //public void BuyTicket(int PlaceId, int PerfomanceId)
        //{

        //    var NewTicket = new TicketEntity()
        //    {
        //        PlaceId = PlaceId,
        //        PerfomanceId = PerfomanceId
        //    };
        //    _dbContext.Tickets.Add(NewTicket);
        //    _dbContext.SaveChanges();
        //}



        public bool CheckIfTicketExist(int PlaceId, int PerfomanceId)
        {
            var CheckTicketExist = _dbContext.Set<TicketEntity>()
               .Where(ticket => ticket.PerfomanceId == PerfomanceId && ticket.PlaceId == PlaceId).ToList();
            return CheckTicketExist.Any();
            
        }

        public IEnumerable<int> GetAllBusyPlacesFromTickets(int PerfomanceId)
        {
            var ticketEntities = _dbContext.Set<TicketEntity>().ToList();
            var result = _dbContext
                .Set<TicketEntity>()
                .Where(x => x.PerfomanceId == PerfomanceId)
                .Select(x => x.PlaceId)
                .ToList();
            return result;
        }
    }
}
