using Microsoft.AspNetCore.Mvc;
using ProofOfConcept.CrmWebApiIntegration.Model;

namespace ProofOfConcept.Controllers
{
    public class CrmWebApiController : Controller
    {
        // GET
        public IActionResult Login()
        {
            return
            View("Login");
        }
        
        [HttpPost]
        public void Authenticate(LoginCredentials creds)
        {
            Response.Redirect(creds.Username == "tk" ? "Commandlist" : "Login");
        }

        public IActionResult CommandList()
        {
            return
            View("CommandList");
        }

    }
}