using Microsoft.AspNetCore.Mvc;

namespace ProofOfConcept.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET
        public IActionResult Login()
        {
            return
            View();
        }
    }
}