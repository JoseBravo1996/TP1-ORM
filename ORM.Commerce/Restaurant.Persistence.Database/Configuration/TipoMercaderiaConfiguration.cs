using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain;
using System.Collections.Generic;

namespace Restaurant.Persistence.Database.Configuration
{
    public class TipoMercaderiaConfiguration
    {
        public TipoMercaderiaConfiguration(EntityTypeBuilder<TipoMercaderia> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.TipoMercaderiaId);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(50);

            // TipoMercaderia by Default

            var formaEntrega = new List<TipoMercaderia>();

            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 1, Descripcion = "Entrada" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 2, Descripcion = "Minutas" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 3, Descripcion = "Pastas" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 4, Descripcion = "Parrilla" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 5, Descripcion = "Pizzas" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 6, Descripcion = "Sandwich" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 7, Descripcion = "Ensaladas" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 8, Descripcion = "Bebidas" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 9, Descripcion = "Cerveza Artesanal" });
            formaEntrega.Add(new TipoMercaderia { TipoMercaderiaId = 10, Descripcion = "Postres" });

            entityBuilder.HasData(formaEntrega);
        }
    }
}
