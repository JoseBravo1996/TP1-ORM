using System;
using System.Collections.Generic;

namespace Restaurant.Service.EventHandlers.Commands
{
    public class ComandaCreateCommand
    {
        public Guid ComandaId { get; set; }
        public int FormaEntregaId { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public List<ComandaMercaderiaCreateCommand> ComandaMercaderia { get; set; }
    }
}
