using System.Collections.Generic;

namespace ASP_Homework_Product
{
        public interface IProductsRepository
        {
            List<Product> GetProducts();
            Product TryGetById(int id);
        }
}
