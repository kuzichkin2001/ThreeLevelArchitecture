using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL_Interface;
using DAO;
using DAO_Interface;
using ProjectEntities;

namespace BL
{
    public class ProductBl : IProductBl
    {
        private IProductDao _productDao = new ProductDao();

        public ProductBl()
        {
            this._productDao = new ProductDao();
        }
        private void RaiseProductArgumentException(Product item)
        {
            const string incorrectChars = "0123456789!@#$%^&*-_+=";
            for (int i = 0; i < item.ProductName.Length; ++i)
            {
                if (((List<char>)item.ProductName.Intersect(incorrectChars)).Count != 0)
                {
                    throw new ProductArgumentException("Name of product contains incorrect symbols.");
                }
                else if (item.Cost < 0)
                {
                    throw new ProductArgumentException("That is impossible to have a negative cost. Think about it.");
                }
                else if ((DateTime)item.SaleInfo.SaleStartDate > (DateTime)item.SaleInfo.SaleEndDate)
                {
                    throw new ProductArgumentException("Your sale would be ended earlier, than it would be started.");
                }
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return this._productDao.GetAllProducts();
        }

        public IEnumerable<Product> SearchByProductName(string productName)
        {
            return this._productDao.SearchByProductName(productName);
        }

        public void AddNewProduct(Product product)
        {
            RaiseProductArgumentException(product);
            this._productDao.AddNewProduct(product);
        }

        public void DeleteProduct(int idProduct)
        {
            this._productDao.DeleteProduct(idProduct);
        }
        public IEnumerable<Product> GetAllSaleInfo()
        {
            return this._productDao.GetAllSaleInfo();
        }

        public IEnumerable<Product> SearchBySaleDate(DateTime currentDate)
        {
            return this._productDao.SearchBySaleDate(currentDate);
        }

        public void DeleteSaleInfo(int idProduct)
        {
            this._productDao.DeleteSaleInfo(idProduct);
        }

        public void UpdateSaleInfo(int idProduct, double cost, double salePercent, DateTime? saleStartDate, DateTime? saleEndDate)
        {
            this._productDao.UpdateSaleInfo(idProduct, cost, salePercent, saleStartDate, saleEndDate);
        }
    }
}
