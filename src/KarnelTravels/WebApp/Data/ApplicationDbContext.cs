using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var i in builder.Model.GetEntityTypes())
            {
                var tableName = i.GetTableName();
                if (tableName!.StartsWith("AspNet"))
                {
                    i.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
