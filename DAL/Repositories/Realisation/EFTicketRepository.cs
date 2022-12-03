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
    }
}
