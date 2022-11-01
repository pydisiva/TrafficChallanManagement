using Microsoft.EntityFrameworkCore;

namespace TrafficChallanManagement.Models
{
    public class TrafficDbContext:DbContext
    {
        public TrafficDbContext()
        {

        }

        public TrafficDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("dbconn"));
        }

        public DbSet<Challan> challans { get; set; }

    }
}
