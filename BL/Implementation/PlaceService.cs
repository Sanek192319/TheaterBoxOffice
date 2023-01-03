using BL.Abstraction;
using BL.Mappers;
using DAL.UnitOfWork.Abstraction;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    class PlaceService : IPlaceService<int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<DataModel.Place<int>> GetAllAvaliablePlaces(int PerfomanceId, int hallId)
        {
            var busyByTicketPlaceIds = _unitOfWork
                .TicketRepository
                .GetAllBusyPlacesFromTickets(PerfomanceId);

            var busyByBookingPlaceIds = _unitOfWork
                .BookingRepository
                .GetAllBusyPlacesFromBookings(PerfomanceId);

            var busyPlacesId = new List<int>();
            busyPlacesId.AddRange(busyByTicketPlaceIds);
            busyPlacesId.AddRange(busyByBookingPlaceIds);

            var NotBusyPlaces = _unitOfWork
                .PlaceRepository
                .GetNotBusyPlaces(busyPlacesId, hallId)
                .Select(x => x.ToModelEntity());

            return NotBusyPlaces;
        }

        public Place<int> GetPlaceById(int id)
        {
            var result = _unitOfWork
               .PlaceRepository
               .GetById(id).ToModelEntity();
            return result;
        }
    }
}
