using System.Collections.Generic;
using System;
using System.Linq;
namespace ASP_Homework_Product
{
    public class Catalog
    {
        public Guid Id;
        public string UserId { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }
    }
}
