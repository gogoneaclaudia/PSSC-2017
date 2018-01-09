using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD_Project.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        /*
        public Products(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
        */

        public void AddDiscount(int percentage)
        {
            decimal discount = Price * percentage / 100;

            if (percentage < 100 && Price - discount > 0)
            {
                Price -= discount;
            }
        }
    }
}