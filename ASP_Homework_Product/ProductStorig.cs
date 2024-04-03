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
        private static List<Product> products = new List<Product>
        {
            new Product("туфли",100,"dkvdvnkdvn"),
            new Product("туфли",200,"dkvdvnkdvn"),
            new Product("туфли",300,"dkvdvnkdvn"),
            new Product("туфли",400,"dkvdvnkdvn")
        };
        public List<Product> GetProducts()
        {
            return products;
        }
        
    }
}
