using Microsoft.AspNetCore.Mvc;
using PriceNegotiationApp.Data;
using PriceNegotiationApp.Entities;

namespace PriceNegotiationApp.Services
{
    public class ProductService(NegotiationDbContext dbContext) : ControllerBase
    {
        private readonly NegotiationDbContext _dbContext = dbContext;

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public bool CreateProduct(Product newProduct)
        {
            if (newProduct is null) return false;
            newProduct.Id = _dbContext.Products.Max(p => p.Id) + 1;
            _dbContext.Products.Add(newProduct);
            return true;
        }
    }
}
