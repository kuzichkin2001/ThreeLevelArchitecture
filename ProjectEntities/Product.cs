using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    public class Product
    {
        private static int _uniqueId = 0;
        public int Id;
        private string _productName;
        private double _cost;
        private Sale _saleInfo;

        public Product(string productName, double cost, Sale saleInfo)
        {
            Id = _uniqueId++;
            _productName = productName;
            _cost = cost;
            _saleInfo = saleInfo;
        }
        public Product(int id, string productName, double cost, Sale saleInfo)
        {
            Id = id;
            _productName = productName;
            _cost = cost;
            _saleInfo = saleInfo;
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public Sale SaleInfo
        {
            get
            {
                return _saleInfo;
            }
            set
            {
                _saleInfo = value;
            }
        }

        public int CompareTo(Product p)
        {
            return Id.CompareTo(p.Id);
        }

        public override string ToString()
        {
            if (SaleInfo.IsSelling)
            {
                return $"Product {ProductName} with id {Id} " +
                $"is selling with {SaleInfo.SalePercent}% discount. " +
                $"Start date: {SaleInfo.SaleStartDate:f}. End Date: {SaleInfo.SaleEndDate:f}. " +
                $"Start cost is {Cost}. New cost is {Cost - Cost * SaleInfo.SalePercent / 100}";
            }
            else
            {
                return $"Product {ProductName} with id {Id} " +
                $"is not selling. " +
                $"The cost is {Cost}";
            }
        }
    }
}
