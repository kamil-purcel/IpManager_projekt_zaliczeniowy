using IpManager.Models;
using Microsoft.EntityFrameworkCore;

namespace IpManager
{
    public class AppContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=IpManagerDatabase;user=root;password=zaq1@WSX;",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
