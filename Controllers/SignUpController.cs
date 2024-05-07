using Experiments.Models;
using Experiments.Services;
using Microsoft.AspNetCore.Mvc;

namespace Experiments.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly SignUpContext _context;

        public SignUpController(SignUpContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {

                var newUser = new SignUpModel
                {
                    username = signUpModel.username,
                    password = signUpModel.password
                };

                // Add the new user to the Users DbSet
                _context.Users.Add(newUser);

                // Save changes to the database
                _context.SaveChanges();

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
