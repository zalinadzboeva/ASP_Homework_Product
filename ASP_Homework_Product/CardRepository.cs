using System.Collections.Generic;
using System;
using System.Linq;
namespace ASP_Homework_Product
{
    public class CardRepository
    {
            private  List<Catalog> carts = new List<Catalog>();

            internal  Catalog TryGetByUserId(string userId)
            {
                return carts.FirstOrDefault(x => x.UserId == userId);
            }

            public  void Add(Product product, string userId)
            {
                var exisitingCart = TryGetByUserId(userId);
                if (exisitingCart == null)
                {
                    var newCart = new Catalog
                    {
                        Id = Guid.NewGuid(),
                        UserId = userId,
                        Items = new List<CartItem>
                    {
                        new CartItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product,
                        }
                    }
                    };

                    carts.Add(newCart);
                }
                else
                {
                    var existingCartItem = exisitingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                    if (existingCartItem != null)
                    {
                        existingCartItem.Amount += 1;
                    }
                    else
                    {
                        exisitingCart.Items.Add(new CartItem
                        {
                            Id = Guid.NewGuid(),
                            Amount = 1,
                            Product = product,
                        });
                    }
                }
            }
        }
    }
