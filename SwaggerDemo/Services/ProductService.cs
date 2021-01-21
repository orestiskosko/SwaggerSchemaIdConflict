using System;
using System.Collections.Generic;

namespace SwaggerDemo.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }

    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Price = 14.5
                }
            };
        }
    }
}