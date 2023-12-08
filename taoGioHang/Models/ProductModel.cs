using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace taoGioHang.Models
{
    public class ProductModel
    {
  
        private List<CartItem> products;
        public ProductModel()
        {
            this.products = new List<CartItem>()
            {
                new CartItem
                {
                    Id = 1,
                    Name = "Balo chống gù lưng1",
                    Price = 120000,Photo = "item1.jpg"
                },
                   new CartItem
                {
                    Id =2,
                    Name = "Balo chống gù lưng2",
                    Price = 120000,Photo = "item2.jpg"
                },
                 new CartItem
                {
                    Id =3,
                    Name = "Balo chống gù lưng3",
                    Price = 120000,Photo = "item3.jpg"
                }, new CartItem
                {
                    Id =4,
                    Name = "Balo chống gù lưng4",
                    Price = 120000,Photo = "item4.jpg"
                }, new CartItem
                {
                    Id =5,
                    Name = "Balo chống gù lưng5",
                    Price = 120000,Photo = "item5.jpg"
                }, new CartItem
                {
                    Id =8,
                    Name = "Balo chống gù lưng",
                    Price = 120000,Photo = "item8.jpg"
                }, new CartItem
                {
                    Id =6,
                    Name = "Balo chống gù lưng6",
                    Price = 120000,Photo = "item6.jpg"
                },
                  new CartItem
                {
                    Id =7,
                    Name = "Balo chống gù lưng7",
                    Price = 120000,Photo = "item7.jpg"
                },
            };
        }
        public List<CartItem> FindAll()
        {
            return this.products;
        }
        public CartItem FindProduct(int id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}