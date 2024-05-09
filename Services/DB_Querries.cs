using Experiments.Models;
using Microsoft.EntityFrameworkCore;

namespace Experiments.Services
{
    public class DB_Querries
    {
        public static void AddUser(SignUpModel signUpModel,SignUpContext _context) {
            var newUser = new SignUpModel
            {
                username = signUpModel.username,
                password = signUpModel.password
            };

            // Add the new user to the Users DbSet
            _context.Users.Add(newUser);

            // Save changes to the database
            _context.SaveChanges();
        }
    }
}
