using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain;

namespace Restaurant.Persistence.Database.Configuration
{
    public class MercaderiaConfiguration
    {
        public MercaderiaConfiguration(EntityTypeBuilder<Mercaderia> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.MercaderiaId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Ingredientes).IsRequired().HasMaxLength(255);
            entityBuilder.Property(x => x.Preparacion).IsRequired().HasMaxLength(255);
            entityBuilder.Property(x => x.Imagen).IsRequired().HasMaxLength(255);
        }
    }
}
