using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.EventHandlers.Commands
{
    public class ComandaMercaderiaCreateCommand
    {
        public int ComandaMercaderiaId { get; set; }
        public int MercaderiaId { get; set; }
        public Guid ComandaId { get; set; }
    }
}
