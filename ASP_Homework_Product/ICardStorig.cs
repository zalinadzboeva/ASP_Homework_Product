using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface ICardStorig
    {
        void Add(Product product, string userId);
        Catalog TryGetByUserId(string userId);
    }
}
