using BL.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace TheaterBoxOffice.WebMVC.Controllers
{
    public class PerfomancesController : Controller
    {
        private readonly IPerfomanceService<int> _perfomanceService;
        private readonly ITicketService<int> _ticketService;

        public PerfomancesController(ITicketService<int> TicketService,IPerfomanceService<int> PerfomanceService)
        {
            _ticketService = TicketService;
            _perfomanceService = PerfomanceService;
        }

        [Route("/Perfomances")]
        public IActionResult PerfomanceItems()
        {
            var items = _perfomanceService.GetPerfomanceByAuthor("bob");
            return View("AllPerfomances", items);
        }
    }
}
