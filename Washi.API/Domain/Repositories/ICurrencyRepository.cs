using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Washi.API.Domain.Models;

namespace Washi.API.Domain.Repositories
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> ListAsync();
        Task<Currency> FindById(int id);
    }
}
