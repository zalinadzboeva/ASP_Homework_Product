using ASP_Homework_Product;
using Microsoft.AspNetCore.Mvc;

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
            if (product == null)
                return View();
        }
    }
}
