using System;
using System.Collections.Generic;

namespace Restaurant.Domain
{
    public class Comanda
    {
        public Guid ComandaId { get; set; }
        public int FormaEntregaId { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public List<ComandaMercaderia> ComandaMercaderia { get; set; }
    }
}
