using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        public Task<IEnumerable<ProductBrand>> GetProductBrands()
        {
            throw new NotImplementedException();
        }
    }
}
