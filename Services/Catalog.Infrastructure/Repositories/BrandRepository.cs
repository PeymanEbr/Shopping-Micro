using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class BrandRepository(ICatalogContext context) : IBrandRepository
    {
        public Task<IEnumerable<ProductBrand>> GetProductBrands()
        {
            throw new NotImplementedException();
        }
    }
}
