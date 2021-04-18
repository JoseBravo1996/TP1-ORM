using Restaurant.Domain;
using Restaurant.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.EventHandlers.Commands
{
    public class ComandaCreateEventHandler
    {
        private readonly ApplicationDbContext _context;

        public ComandaCreateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ComandaCreateCommand command)
        {
            await _context.AddAsync(new Comanda
            {
                FormaEntregaId = command.FormaEntregaId,
                PrecioTotal = command.PrecioTotal,
                Fecha = command.Fecha
            });
        }
    }
}
