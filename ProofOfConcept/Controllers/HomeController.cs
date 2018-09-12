using Microsoft.AspNetCore.Mvc;
using ProofOfConcept.CrmWebApiIntegration.RestApiAccess;


namespace ProofOfConcept.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvider _dataProvider;

        public HomeController(IProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Events()
        {
            _dataProvider.HttpGet()

        }

    }
}
