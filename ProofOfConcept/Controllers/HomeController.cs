using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProofOfConcept.CrmWebApiIntegration;

namespace ProofOfConcept.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConnectionEventService _eventService;

        public HomeController(IConnectionEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Events()
        {
            var allEvents = _eventService.Retrieve().OrderByDescending(x => x.createdon).Take(10);
            return View("Events", allEvents);
        }
    }
}
