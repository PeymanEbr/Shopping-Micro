using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class ProductRepository(ICatalogContext context) : IProductRepository
    {
        public Task<bool> DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(string id)
        {
            return await context.Products.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await context.Products.Find(x => true).ToListAsync();
        }

        public Task<IEnumerable<Product>> GetProductsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByBrandId(string brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByType(string type)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByTypeId(string typeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
