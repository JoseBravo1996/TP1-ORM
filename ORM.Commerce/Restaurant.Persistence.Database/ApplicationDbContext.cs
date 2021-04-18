using Microsoft.EntityFrameworkCore;
using Restaurant.Domain;
using Restaurant.Persistence.Database.Configuration;

namespace Restaurant.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<ComandaMercaderia> ComandaMercaderia { get; set; }
        public DbSet<FormaEntrega> FormaEntrega { get; set; }
        public DbSet<Mercaderia> Mercaderia { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JOSEBRAVO1\\SQLEXPRESS;Database=OrmCommerce;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new FormaEntregaConfiguration(modelBuilder.Entity<FormaEntrega>());
            new TipoMercaderiaConfiguration(modelBuilder.Entity<TipoMercaderia>());
            new MercaderiaConfiguration(modelBuilder.Entity<Mercaderia>());
        }


    }
}
