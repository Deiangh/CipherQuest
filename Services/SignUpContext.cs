using Experiments.Models;
using Microsoft.EntityFrameworkCore;

namespace Experiments.Services
{
    public class SignUpContext : DbContext
    {
        public DbSet<SignUpModel> Users { get; set; }

        public SignUpContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
