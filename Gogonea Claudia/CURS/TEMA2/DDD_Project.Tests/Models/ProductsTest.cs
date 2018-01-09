using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDD_Project.Models;

namespace DDD_Project.Tests.Models
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void TestProductsAttributes()
        {
            Products product = new Products();

            product.Id = 1;
            product.Name = "Dune";
            product.Price = 10;
            product.Category = "SF";

            Assert.AreEqual(product.Id, 1);
            Assert.AreEqual(product.Name, "Dune");
            Assert.AreEqual(product.Price, 10);
            Assert.AreEqual(product.Category, "SF");
        }

        [TestMethod]
        public void TestProductsDiscount()
        {
            Products product = new Products();

            product.Id = 1;
            product.Price = 10;

            Assert.AreEqual(product.Price, 10);

            product.AddDiscount(10);

            Assert.AreEqual(product.Price, 9);
        }

        // Discount over 100% should not be allowed
        [TestMethod]
        public void TestProductsDiscountOverflow()
        {
            Products product = new Products();

            product.Id = 1;
            product.Price = 10;

            Assert.AreEqual(product.Price, 10);

            product.AddDiscount(110);

            Assert.AreEqual(product.Price, 10);
        }

        // Do not allow price to go under 0
        [TestMethod]
        public void TestProductsDiscountUnderZero()
        {
            Products product = new Products();

            product.Id = 1;
            product.Price = 10;

            Assert.AreEqual(product.Price, 10);

            product.AddDiscount(100);

            Assert.AreEqual(product.Price, 10);
        }
    }
}
