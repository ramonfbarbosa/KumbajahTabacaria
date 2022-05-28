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
        private KumbajahContext Context { get; }

        public CategoryRepository(KumbajahContext context) : base(context)
        {
            Context = context;
        }

        public async Task<Category> GetByCategoryName(string name)
        {
            var categoryName = await Context.Category
                .Where(x => x.Name.ToLower() == name.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return categoryName.FirstOrDefault();
        }

        public async Task<List<Category>> SearchByCategoryName(string name)
        {
            var allCategories = await Context.Category
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .AsNoTracking()
                .ToListAsync();

            return allCategories;
        }
    }
}
