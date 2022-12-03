using DAL.Entites;
using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realisation
{
    public class EFBookingRepository : EFGenericRepository<BookingEntity, int>, IBookingRepository
    {
        public EFBookingRepository(TheaterBoxOfficeDbContext dbContext) : base(dbContext, dbContext.Bookings)
        {

        }

    }
}
