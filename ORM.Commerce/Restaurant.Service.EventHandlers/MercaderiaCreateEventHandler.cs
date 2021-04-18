using MediatR;
using Restaurant.Persistence.Database;
using Restaurant.Service.EventHandlers.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.Service.EventHandlers
{
    public class MercaderiaCreateEventHandler : INotificationHandler<MercaderiaCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public MercaderiaCreateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Handle(MercaderiaCreateCommand notification, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
