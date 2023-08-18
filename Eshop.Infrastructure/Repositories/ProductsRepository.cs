﻿using Eshop.Core.Entities;
using Eshop.Infrastructure.Data;

namespace Eshop.Infrastructure.Repositories
{
    internal sealed class ProductsRepository : Core.Interfaces.IProducts
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Get(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public IEnumerable<Product> List()
        {
            return _dbContext.Products.ToList();
        }
    }
}
