using Microsoft.AspNetCore.Mvc;

namespace HSPAuthTentativeIII.Controllers
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
