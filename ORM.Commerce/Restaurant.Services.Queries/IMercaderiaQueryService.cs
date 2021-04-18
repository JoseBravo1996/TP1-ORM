using Restaurant.Services.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurant.Service.Queries
{
    public interface IMercaderiaQueryService
    {
        Task<List<MercaderiaDto>> GetMercaderias();
    }
}
