using System.Collections.Generic;

namespace Restaurant.Domain
{
    public class TipoMercaderia
    {
        public int TipoMercaderiaId { get; set; }
        public string Descripcion { get; set; }
        public List<Mercaderia> Mercaderia { get; set; }
    }
}
