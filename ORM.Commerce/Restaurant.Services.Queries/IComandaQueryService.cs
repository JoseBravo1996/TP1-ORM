using Restaurant.Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.Queries
{
    public interface IComandaQueryService
    {
        Task<List<ComandaDto>> GetMercaderias();
    }
}
