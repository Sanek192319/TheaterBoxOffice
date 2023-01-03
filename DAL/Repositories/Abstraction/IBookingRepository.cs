using DAL.Entites;
using System.Collections.Generic;

namespace DAL.Repositories.Abstraction
{
    public interface IBookingRepository : IRepository<BookingEntity, int>
    {
        public bool CheckIfBookingExist(int PlaceId, int PerfomanceId);
        //public void BookTicket(int PlaceId, int PerfomanceId);
        public void SellBookedTicket(int PlaceId, int PerfomanceId);

        public IEnumerable<int> GetAllBusyPlacesFromBookings(int PerfomanceId);
    }
}
