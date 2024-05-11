using Experiments.Models;
using Experiments.Services;
using Microsoft.AspNetCore.Mvc;

namespace Experiments.Controllers
{
    public class LoginController : Controller
    {

        private readonly LoginContext _context;
        public LoginController(LoginContext context)
        {
            _context = context;
        }

        public IActionResult Login() { 
            return View("Login");
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("Authenticated");
            return View("Login");
        }

        public IActionResult LoginUser(LoginModel loginModel)
        {

            if (ModelState.IsValid)
            {
                LoginModel? user = DB_Querries.LoginUser(loginModel.username, loginModel.password, _context);
                if (user == null)
                {

                    ModelState.AddModelError(string.Empty, "Invalid username or password. Are you sure you are signed up?");
                    return View("Login", loginModel);

                }

                Response.Cookies.Append("Authenticated", (user.ID).ToString());
                return View("LoginSuccess");
            }
            return View("Login",loginModel);
        }
    }
}
