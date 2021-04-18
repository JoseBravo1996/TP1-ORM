using System;
using System.Collections.Generic;

namespace Restaurant.Services.Queries
{
    public class ComandaDto
    {
        public Guid ComandaId { get; set; }
        public int FormaEntregaId { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public List<ComandaMercaderiaDto> ComandaMercaderia { get; set; }
    }
}
