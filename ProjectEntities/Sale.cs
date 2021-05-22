using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    public class Sale
    {
        private double _salePercent;
        private DateTime? _saleStartDate;
        private DateTime? _saleEndDate;

        public Sale(double salePercent, DateTime? saleStartDate = null, DateTime? saleEndDate = null)
        {
            bool isSelling = (salePercent > 0 && salePercent <= 100);
            IsSelling = isSelling;
            if (isSelling && saleStartDate.HasValue && saleEndDate.HasValue)
            {
                _salePercent = salePercent;
                _saleStartDate = saleStartDate;
                _saleEndDate = saleEndDate;
            }
            else if (isSelling && !(saleStartDate.HasValue && saleEndDate.HasValue))
            {
                throw new Exception("Invalid period input. Sale or/and end date are in incorrect format.");
            }
            else if (isSelling)
            {
                _salePercent = salePercent;
                _saleStartDate = saleStartDate;
                _saleEndDate = saleEndDate;
            }
        }

        public bool IsSelling { get; }

        public double SalePercent
        {
            get
            {
                return _salePercent;
            }
            set
            {
                if (_salePercent == 0)
                {
                    _salePercent = value;
                }
                else if (value > 100 || value < 0)
                {
                    _salePercent = 0;
                }
            }
        }

        public DateTime? SaleStartDate
        {
            get
            {
                return _saleStartDate;
            }
            set
            {
                if (IsSelling)
                {
                    _saleStartDate = value;
                }
            }
        }

        public DateTime? SaleEndDate
        {
            get
            {
                return _saleEndDate;
            }
            set
            {
                if (IsSelling)
                {
                    _saleEndDate = value;
                }
            }
        }

        public int CompareTo(Sale s)
        {
            if (IsSelling && SalePercent == s.SalePercent) return 0;
            else
            {
                if (SalePercent > s.SalePercent) return 1;
                else return -1;
            }
        }
    }
}
