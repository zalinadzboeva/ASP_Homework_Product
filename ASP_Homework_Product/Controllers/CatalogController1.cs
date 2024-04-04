using ASP_Homework_Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

using static ASP_Homework_Product.CardRepository;

namespace WebApplication2.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ProductStorig productStorig;

        private readonly CardRepository cardStorig;
        public CatalogController(ProductStorig productStorig, CardRepository cardStorig)
        {
            this.productStorig = productStorig;
            this.cardStorig = cardStorig;
        }


       public ActionResult Index()
        {
            var catalog = cardStorig.TryGetByUserId(Constant.UserId);
            return View(catalog);
        }

        public IActionResult Add(int productId)
        {
            var product = productStorig.TryGetById(productId);
            cardStorig.Add(product, Constant.UserId);
            return RedirectToAction("Index");
        }
    }
}