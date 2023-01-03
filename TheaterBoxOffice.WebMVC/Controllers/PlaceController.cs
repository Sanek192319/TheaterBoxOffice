using BL.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheaterBoxOffice.WebMVC.ReturnModels;

namespace TheaterBoxOffice.WebMVC.Controllers
{
    public class PlaceController : Controller
    {
        private readonly IPlaceService<int> _placeService;
        private readonly ITicketService<int> _ticketService;
        private readonly IBookingService<int> _bookingService;

        public PlaceController(ITicketService<int> TicketService, IBookingService<int> BookingService,IPlaceService<int> PlaceService)
        {
            _ticketService = TicketService;
            _bookingService = BookingService;
            _placeService = PlaceService;
        }

        [Route("/Places/Showplaces")]
        public IActionResult PlaceItems(int id,int hallId)
        {

            var NewTicketsModelList = new List<ReturnModelForTickets<int>>();
            var items = _placeService.GetAllAvaliablePlaces(id, hallId);
            foreach (var item in items)
            {
                var _newModel = new ReturnModelForTickets<int>();
                _newModel.Id = item.Id;
                _newModel.Price = item.price;
                _newModel.HallId = item.HallId;
                _newModel.PlaceNumber = item.PlaceNumber;
                _newModel.PerfomanceId = id;
                NewTicketsModelList.Add(_newModel);
            }
            return View("MyPlaces", NewTicketsModelList);
        }

        [Route("/Tickets/SellTicket")]
        public IActionResult TicketItems(int id, int PerfomanceId, int hallid)
        {
            _ticketService.BuyTicket(id, PerfomanceId);

            var NewTicketsModelList = new List<ReturnModelForTickets<int>>();
            var items = _placeService.GetAllAvaliablePlaces(PerfomanceId, hallid);
            foreach (var item in items)
            {
                var _newModel = new ReturnModelForTickets<int>();
                _newModel.Id = item.Id;
                _newModel.Price = item.price;
                _newModel.HallId = item.HallId;
                _newModel.PlaceNumber = item.PlaceNumber;
                _newModel.PerfomanceId = PerfomanceId;
                NewTicketsModelList.Add(_newModel);
            }
           // IEnumerable<ReturnModelForTickets<int>> obj = NewTicketsModelList;
            return View("MyPlaces", NewTicketsModelList);
        }

        [Route("/Tickets/BookTickets")]
        public IActionResult BookItems(int id, int PerfomanceId, int hallid)
        {
            _bookingService.BookTicket(id, PerfomanceId);

            var NewTicketsModelList = new List<ReturnModelForTickets<int>>();
            var items = _placeService.GetAllAvaliablePlaces(PerfomanceId, hallid);
            foreach (var item in items)
            {
                var _newModel = new ReturnModelForTickets<int>();
                _newModel.Id = item.Id;
                _newModel.Price = item.price;
                _newModel.HallId = item.HallId;
                _newModel.PlaceNumber = item.PlaceNumber;
                _newModel.PerfomanceId = PerfomanceId;
                NewTicketsModelList.Add(_newModel);
            }
            // IEnumerable<ReturnModelForTickets<int>> obj = NewTicketsModelList;
            return View("MyPlaces", NewTicketsModelList);
        }
    }
}
