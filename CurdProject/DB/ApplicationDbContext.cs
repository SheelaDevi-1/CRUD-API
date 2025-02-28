using CurdProject.Model;
using Microsoft.EntityFrameworkCore;

namespace CurdProject.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }


    }
}
