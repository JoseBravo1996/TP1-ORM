using Restaurant.Persistence.Database;
using Restaurant.Services.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Service.Queries
{
    public class MercaderiaQueryService
    {
        private readonly ApplicationDbContext _context;

        public MercaderiaQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<MercaderiaDto>> GetMercaderias()
        {
            return null;
        }
    }
}