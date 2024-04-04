using ASP_Homework_Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

using static ASP_Homework_Product.CardRepository;

namespace WebApplication2.Controllers
{
    public class CatalogController : Controller
    {
        private ProductStorig productStorig;
        public CatalogController()
        {
            productStorig = new ProductStorig();
        }

       public ActionResult Index()
        {
            var catalog = CartsRepository.TryGetByUserId(Constant.UserId);
            return View(catalog);
        }

        public IActionResult Add(int productId)
        {
            var product = productStorig.TryGetById(productId);
            CartsRepository.Add(product, Constant.UserId);
            return RedirectToAction("Index");
        }
    }
}