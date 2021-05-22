using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BL;
using BL_Interface;
using ProjectEntities;

namespace ProjectTests
{
    [TestClass]
    public class ProductTests
    {
        private IProductBl _productBl = new ProductBl();

        [TestMethod]
        [ExpectedException(typeof(ProductArgumentException), "Name of product contains incorrect symbols.")]
        public void CheckProductName()
        {
            string productName = "хохлома";
            double cost = 134.6;
            double salePercent = 13;
            DateTime? saleStartDate = new DateTime(2021, 5, 21);
            DateTime? saleEndDate = new DateTime(2021, 5, 27);
            var item = new Product(
                productName: productName,
                cost: cost,
                saleInfo: new Sale(
                    salePercent: salePercent,
                    saleStartDate: saleStartDate,
                    saleEndDate: saleEndDate
                )
            );
            _productBl.AddNewProduct(item);

            item.ProductName = "хох1231лома";
            _productBl.AddNewProduct(item);
        }

        [TestMethod]
        [ExpectedException(typeof(ProductArgumentException), "That is impossible to have a negative cost. Think about it.")]
        public void CheckProductCost()
        {
            string productName = "хохлома";
            double cost = 134.6;
            double salePercent = 13;
            DateTime? saleStartDate = new DateTime(2021, 5, 21);
            DateTime? saleEndDate = new DateTime(2021, 5, 27);
            var item = new Product(
                productName: productName,
                cost: cost,
                saleInfo: new Sale(
                    salePercent: salePercent,
                    saleStartDate: saleStartDate,
                    saleEndDate: saleEndDate
                )
            );
            _productBl.AddNewProduct(item);

            item.Cost = -1231;
            _productBl.AddNewProduct(item);
        }

        [TestMethod]
        [ExpectedException(typeof(ProductArgumentException), "Your sale would be ended earlier, than it would be started.")]
        public void CheckProductSaleDates()
        {
            string productName = "хохлома";
            double cost = 134.6;
            double salePercent = 13;
            DateTime? saleStartDate = new DateTime(2021, 5, 21);
            DateTime? saleEndDate = new DateTime(2021, 5, 27);
            var item = new Product(
                productName: productName,
                cost: cost,
                saleInfo: new Sale(
                    salePercent: salePercent,
                    saleStartDate: saleStartDate,
                    saleEndDate: saleEndDate
                )
            );
            _productBl.AddNewProduct(item);

            item.SaleInfo.SaleStartDate = new DateTime(2021, 5, 27);
            item.SaleInfo.SaleEndDate = new DateTime(2021, 5, 21);
            _productBl.AddNewProduct(item);
        }
    }
}
