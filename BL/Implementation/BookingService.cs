using BL.Abstraction;
using BL.Mappers;
using DAL.Entites;
using DAL.UnitOfWork.Abstraction;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    class BookingService : IBookingService<int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void BookTicket(int PlaceId, int PerfomanceId)
        {
            if (!_unitOfWork.TicketRepository.CheckIfTicketExist(PlaceId, PerfomanceId)
               && !_unitOfWork.BookingRepository.CheckIfBookingExist(PlaceId, PerfomanceId))
            {
                var NewBooking = new BookingEntity()
                {
                    PlaceId = PlaceId,
                    PerfomanceId = PerfomanceId
                };
                _unitOfWork.BookingRepository.Create(NewBooking);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Booking<int>> GetAllBookings()
        {
            var result = _unitOfWork
   .BookingRepository
   .GetAll()
   .Select(entity => entity.ToModelEntity())
   .ToList();
            return result;
        }

        public void SellBookedTicket(int PlaceId, int PerfomanceId)
        {
            _unitOfWork.BookingRepository.SellBookedTicket(PlaceId, PerfomanceId);
            var NewTicket = new TicketEntity()
            {
                PlaceId = PlaceId,
                PerfomanceId = PerfomanceId
            };
            _unitOfWork.TicketRepository.Create(NewTicket);
            _unitOfWork.Save();
        }
    }
}
