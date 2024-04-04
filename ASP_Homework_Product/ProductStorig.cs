using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASP_Homework_Product
{
    public class ProductStorig
    {
        private  List<Product> products = new List<Product>
        {
            new Product("чашка",100,"dkvdvnkdvn","/imeges/imeg1.jpg"),
            new Product("чашка",200,"dkvdvnkdvn","/imeges/imeg2.jpg"),
            new Product("чашка",300,"dkvdvnkdvn","/imeges/imeg3.jpg"),
            new Product("чашка",400,"dkvdvnkdvn", "/imeges/imeg4.jpg")
        };
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product TryGetById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }
    }
}
