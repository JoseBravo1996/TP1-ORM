using System.Collections.Generic;

namespace Restaurant.Services.Queries
{
    public class FormaEntregaDto
    {
        public int FormaEntregaId { get; set; }
        public string Descripcion { get; set; }
        public List<ComandaDto> Comanda { get; set; }
    }
}
