using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> contextOptions):
            base(contextOptions)
        { 

        }
        
        public DbSet <Student> Students { get; set; }
       
    }
}
