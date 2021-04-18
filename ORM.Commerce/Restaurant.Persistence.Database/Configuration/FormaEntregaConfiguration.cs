using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain;
using System.Collections.Generic;

namespace Restaurant.Persistence.Database.Configuration
{
    public class FormaEntregaConfiguration
    {
        public FormaEntregaConfiguration(EntityTypeBuilder<FormaEntrega> entityBuilder) 
        {
            entityBuilder.HasIndex(x => x.FormaEntregaId);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(50);

            // FormaEntrega by Default

            var formaEntrega = new List<FormaEntrega>();

            formaEntrega.Add(new FormaEntrega { FormaEntregaId = 1, Descripcion = "Salon" });
            formaEntrega.Add(new FormaEntrega { FormaEntregaId = 2, Descripcion = "Delivery" });
            formaEntrega.Add(new FormaEntrega { FormaEntregaId = 3, Descripcion = "Pedidos Ya" });


            entityBuilder.HasData(formaEntrega);
        }
    }
}
