using Microsoft.EntityFrameworkCore;

namespace Sprint2Project.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModule> UserModule { get; set; }
        public DbSet<ProjectModule> ProjectModule { get; set; }
        public DbSet<TaskModule> TaskModule { get; set; }

    }
}
