using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2026.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veículo> Veiculos { get; set; }
    }
}
