using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private new readonly KumbajahContext _context;

        public CategoryRepository(KumbajahContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Category> GetByCategoryName(string name)
        {
            var categoryName = await _context.Category
                .Where(x => x.Name.ToLower() == name.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return categoryName.FirstOrDefault();
        }

        public async Task<List<Category>> SearchByCategoryName(string name)
        {
            var allCategories = await _context.Category
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allCategories;
        }
    }
}
