using BL.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheaterBoxOffice.WebMVC.ReturnModels;

namespace TheaterBoxOffice.WebMVC.Controllers
{
    public class BookingsController : Controller
    {
        private readonly IBookingService<int> _bookingService;
        private readonly IPerfomanceService<int> _perfomanceService;
        private readonly IHallService<int> _hallService;
        private readonly IPlaceService<int> _placeService;

        public BookingsController(IBookingService<int> BookingService, IPerfomanceService<int> PerfomanceService
            , IHallService<int> HallService, IPlaceService<int> placeService)
        {
            _bookingService = BookingService;
            _perfomanceService = PerfomanceService;
            _hallService = HallService;
            _placeService = placeService;
        }
        [Route("/Bookings")]
        public IActionResult TicketsItems()
        {
            var items = _bookingService.GetAllBookings();
            var ReturnModelList = new List<ReturnModelForBookings<int>>();
            foreach (var item in items)
            {
                var NewModel = new ReturnModelForBookings<int>();
                var perfomance = _perfomanceService.GetPerfomanceById(item.PerfomanceId);
                var hall = _hallService.GetHallById(perfomance.HallId);
                var place = _placeService.GetPlaceById(item.PlaceId);
                NewModel.Id = item.Id;
                NewModel.PerfomanceId = item.PerfomanceId;
                NewModel.PlaceId = item.PlaceId;
                NewModel.PerfomanceName = perfomance.PerfomanceName;
                NewModel.PerfomanceDate = perfomance.PerfomanceDate;
                NewModel.HallNumber = hall.HallNumber;
                NewModel.PlaceNumber = place.PlaceNumber;
                ReturnModelList.Add(NewModel);
            }
            return View("BookedTickets", ReturnModelList);
        }

        [Route("/Bookings/SellTicket")]
        public IActionResult BookingsItems(int PlaceId, int PerfomanceId)
        {
            _bookingService.SellBookedTicket(PlaceId, PerfomanceId);
            var items = _bookingService.GetAllBookings();
            var ReturnModelList = new List<ReturnModelForBookings<int>>();
            foreach (var item in items)
            {
                var NewModel = new ReturnModelForBookings<int>();
                var perfomance = _perfomanceService.GetPerfomanceById(item.PerfomanceId);
                var hall = _hallService.GetHallById(perfomance.HallId);
                var place = _placeService.GetPlaceById(item.PlaceId);
                NewModel.Id = item.Id;
                NewModel.PerfomanceId = item.PerfomanceId;
                NewModel.PlaceId = item.PlaceId;
                NewModel.PerfomanceName = perfomance.PerfomanceName;
                NewModel.PerfomanceDate = perfomance.PerfomanceDate;
                NewModel.HallNumber = hall.HallNumber;
                NewModel.PlaceNumber = place.PlaceNumber;
                ReturnModelList.Add(NewModel);
            }
            return View("BookedTickets", ReturnModelList);
        }
        
    }
}
