using Microsoft.EntityFrameworkCore;

namespace Kisiselweb.Models.Classes
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AS-TASKIN63;Database=Kisiselweb;User Id=sa;Password=1q2w3e4r+!;TrustServerCertificate=True");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Icons> Icons { get; set; }

    }
    
}
