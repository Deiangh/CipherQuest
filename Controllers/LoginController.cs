using Experiments.Models;
using Experiments.Services;
using Microsoft.AspNetCore.Mvc;

namespace Experiments.Controllers
{
    public class LoginController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }

        private readonly LoginContext _context;
        public LoginController(LoginContext context)
        {
            _context = context;
        }

        public LoginModel GetUserByUsernameAndPassword(string username, string password)
        {
            // Query the users table for a user with the given username and password
            return _context.Users.FirstOrDefault(u => u.username == username && u.password == password);
        }

        public IActionResult Login(LoginModel loginModel) {

            if (ModelState.IsValid)
            {

            }
            return View(loginModel);
        }
    }
}
