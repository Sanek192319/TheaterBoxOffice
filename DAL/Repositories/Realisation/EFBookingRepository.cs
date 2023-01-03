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

        //public void BookTicket(int PlaceId, int PerfomanceId)
        //{
        //    var NewBooking = new BookingEntity()
        //    {
        //        PlaceId = PlaceId,
        //        PerfomanceId = PerfomanceId
        //    };
        //    _dbContext.Bookings.Add(NewBooking);
        //    _dbContext.SaveChanges();
        //}

        public bool CheckIfBookingExist(int PlaceId, int PerfomanceId)
        {
            var CheckBookingExist = _dbContext.Set<BookingEntity>()
                 .Where(booking => booking.PerfomanceId == PerfomanceId &&
                 booking.PlaceId == PlaceId).ToList();

            return CheckBookingExist.Any();
            
        }

        public IEnumerable<int> GetAllBusyPlacesFromBookings(int PerfomanceId)
        {
            var result = _dbContext.Set<BookingEntity>()
                .Where(x => x.PerfomanceId == PerfomanceId)
                .Select(x => x.PlaceId)
                .ToList();
            return result;
        }

        public void SellBookedTicket(int PlaceId, int PerfomanceId)
        {
            var BookingForRemoving = _dbContext
               .Bookings
               .FirstOrDefault(booking => booking.PlaceId == PlaceId && booking.PerfomanceId == PerfomanceId);
            _dbContext.Bookings.Remove(BookingForRemoving);

        }
    }
}
