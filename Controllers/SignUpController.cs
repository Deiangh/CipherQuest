using Experiments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Experiments.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                // Save user to database (e.g., using Entity Framework Core)
                // Your code to save the user to the database goes here

                // Redirect to a success page or another action
                return RedirectToAction("SignUpSuccess");
            }

            // If ModelState is not valid, return the SignUp view with errors
            return View("Index", signUpModel);
        }

        public IActionResult SignUpSuccess()
        {
            return View();
        }
    }
}
