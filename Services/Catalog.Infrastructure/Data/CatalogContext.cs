using Catalog.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Data
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }

        public IMongoCollection<ProductBrand> Brands { get; }

        public IMongoCollection<ProductType> Types { get; }

        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var databse = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            //Get of all collections
            Products = databse.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            Brands = databse.GetCollection<ProductBrand>(configuration.GetValue<string>("DatabaseSettings:BrandsCollection"));
            Types = databse.GetCollection<ProductType>(configuration.GetValue<string>("DatabaseSettings:TypesCollection"));

            //
            BrandSeedData.SeedData(Brands);
            TypesSeedData.SeedData(Types);
            ProductSeedData.SeedData(Products);
        }
    }
}
