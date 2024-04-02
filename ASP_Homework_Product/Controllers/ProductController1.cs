using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_Homework_Product.Models;
using ASP_Homework_Product;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private ProductStorig productStorig;
        public ProductController()
        {
            productStorig = new ProductStorig();
        }
        public IActionResult Index(int id)
        {
            var product = productStorig.TryGetById(id);
            return View((object)product);
            if(product == null)
                return View();
        }
    }
}
