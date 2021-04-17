using System.Collections.Generic;

namespace Restaurant.Domain
{
    public class FormaEntrega
    {
        public int FormaEntregaId { get; set; }
        public string Descripcion { get; set; }
        public List<Comanda> Comanda { get; set; }
    }
}
