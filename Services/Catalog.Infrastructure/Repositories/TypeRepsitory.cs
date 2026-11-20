using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class TypeRepsitory : ITypeRepsitory
    {
        public Task<IEnumerable<ProductType>> GetProductTypes()
        {
            throw new NotImplementedException();
        }
    }
}
