using Microsoft.AspNetCore.Mvc;

namespace Experiments.Controllers
{
    public class LoginController : Controller
    {

        public LoginController() { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
