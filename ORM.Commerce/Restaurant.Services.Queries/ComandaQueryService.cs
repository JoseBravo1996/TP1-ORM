using Restaurant.Persistence.Database;
using Restaurant.Services.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Service.Queries
{
    public class ComandaQueryService
    {
        private readonly ApplicationDbContext _context;

        public ComandaQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<ComandaDto>> GetMercaderias()
        {
            return null;
        }
    }
}
