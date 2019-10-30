using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWebAPI.Repository
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            for (int i = 1; i < 10; i++)
            {
                products.Add(new Product()
                {
                    Id = i,
                    Title = $"Title {i}",
                    Price = 10.00
                });
            }

            return products;
        }

        public Product GetProduct(int id)
        {
            return GetProducts().SingleOrDefault(p => p.Id == id);
        }
    }
}
