
using Microsoft.EntityFrameworkCore;
using SBSC_Challenge.Entities;

namespace SBSC_Challenge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students {get; set;}
    }
}