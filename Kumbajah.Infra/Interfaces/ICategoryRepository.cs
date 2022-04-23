using Kumbajah.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbajah.Infra.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
		public void PrePersist();
		public void PreUpdate();

	}
}
