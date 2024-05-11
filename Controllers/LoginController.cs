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

        public IActionResult LoginWithCookies() { 
            if (Request.Cookies.TryGetValue("Authenticated",out _))
            { 
                
                return View("Cookies"); 
            }
            return View("Index");
        }

        public IActionResult Login(LoginModel loginModel)
        {

            if (ModelState.IsValid)
            {
                LoginModel? user = DB_Querries.LoginUser(loginModel.username, loginModel.password, _context);
                if (user == null)
                {

                    ModelState.AddModelError(string.Empty, "Invalid username or password. Are you sure you are signed up?");
                    return View("Index", loginModel);

                }

                Response.Cookies.Append("Authenticated", (user.ID).ToString());
                return View("LoginSuccess");
            }
            return View("Index",loginModel);
        }
    }
}
