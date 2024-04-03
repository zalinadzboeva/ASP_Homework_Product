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
    public class Product
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }

        List<Product> Products { get; set; }

        public Product(string name, int cost , string description)
        {
            Id = counter;
            Name = name;
            Cost = cost;
            Description = description;
            counter++;
        }
        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
