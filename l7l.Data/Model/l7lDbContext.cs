using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
namespace l7l.Data.Model
{
    public class l7lDbContext : DbContext
    {
        public l7lDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}