using System.Collections.Generic;

namespace Restaurant.Services.Queries
{
    public class TipoMercaderiaDto
    {
        public int TipoMercaderiaId { get; set; }
        public string Descripcion { get; set; }
        public List<MercaderiaDto> Mercaderia { get; set; }
    }
}
