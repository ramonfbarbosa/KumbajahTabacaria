using Kumbajah.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<Category> GetByCategoryName(string name);
        Task<List<Category>> SearchByCategoryName(string name);
    }
}
