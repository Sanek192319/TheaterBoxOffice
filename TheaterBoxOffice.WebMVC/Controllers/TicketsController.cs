using BL.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheaterBoxOffice.WebMVC.ReturnModels;

namespace TheaterBoxOffice.WebMVC.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService<int> _ticketService;
        private readonly IPerfomanceService<int> _perfomanceService;
        private readonly IHallService<int> _hallService;
        private readonly IPlaceService<int> _placeService;

        public TicketsController(ITicketService<int> TicketService, IPerfomanceService<int> PerfomanceService
            , IHallService<int> HallService, IPlaceService<int> placeService )
        {
            _ticketService = TicketService;
            _perfomanceService = PerfomanceService;
            _hallService = HallService;
            _placeService = placeService;
        }
        [Route("/Tickets")]
        public IActionResult TicketsItems()
        {

            var items = _ticketService.GetAllTickets();
            var ReturnModelList = new List<ReturnModelForSelledTickets<int>>();
            foreach (var item in items)
            {
                var NewModel = new ReturnModelForSelledTickets<int>();
                var perfomance = _perfomanceService.GetPerfomanceById(item.PerfomanceId);
                var hall = _hallService.GetHallById(perfomance.HallId);
                var place = _placeService.GetPlaceById(item.PlaceId);
                NewModel.Id = item.Id;
                NewModel.PerfomanceName = perfomance.PerfomanceName;
                NewModel.PerfomanceDate = perfomance.PerfomanceDate;
                NewModel.HallNumber = hall.HallNumber;
                NewModel.PlaceNumber = place.PlaceNumber;
                ReturnModelList.Add(NewModel);
            }
            return View("SelledTickets", ReturnModelList);
        }
    }
}
