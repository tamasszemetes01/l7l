using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace l7l.Data.Model
{
    public class l7lDbContextFactory : IDesignTimeDbContextFactory<l7lDbContext>
    {
        public l7lDbContext CreateDbContext(string[] args)
        {
            var builder=new DbContextOptionsBuilder<l7lDbContext>();

            builder.UseSqlite("Data Source=l7l.db;");

            return new l7lDbContext(builder.Options);
        }
    }
}