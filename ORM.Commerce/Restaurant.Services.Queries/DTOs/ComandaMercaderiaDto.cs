using System;

namespace Restaurant.Services.Queries
{
    public class ComandaMercaderiaDto
    {
        public int ComandaMercaderiaId { get; set; }
        public int MercaderiaId { get; set; }
        public Guid ComandaId { get; set; }
    }
}
