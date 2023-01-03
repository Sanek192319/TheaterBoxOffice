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
     class TicketService : ITicketService<int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TicketService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void BuyTicket(int PlaceId, int PerfomanceId)
        {
            if (!_unitOfWork.TicketRepository.CheckIfTicketExist(PlaceId, PerfomanceId) 
                && !_unitOfWork.BookingRepository.CheckIfBookingExist(PlaceId, PerfomanceId))
            {
                var NewTicket = new TicketEntity()
                {
                    PlaceId = PlaceId,
                    PerfomanceId = PerfomanceId
                };
                _unitOfWork.TicketRepository.Create(NewTicket);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<Ticket<int>> GetAllTickets()
        {
            var result = _unitOfWork
               .TicketRepository
               .GetAll()
               .Select(entity => entity.ToModelEntity())
               .ToList();
            return result;
        }
    }
}
