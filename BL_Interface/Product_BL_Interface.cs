using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntities;

namespace BL_Interface
{
    public interface IProductBl
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> SearchByProductName(string productName);
        void AddNewProduct(Product product);
        void DeleteProduct(int idProduct);
        IEnumerable<Product> GetAllSaleInfo();
        IEnumerable<Product> SearchBySaleDate(DateTime currentDate);
        void DeleteSaleInfo(int idProduct);
        void UpdateSaleInfo(int idProduct, double cost, double salePercent, DateTime? saleStartDate, DateTime? saleEndDate);
    }
}
