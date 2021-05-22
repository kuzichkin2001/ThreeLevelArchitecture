using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductArgumentException : Exception
    {
        public ProductArgumentException() { }
        public ProductArgumentException(string message) : base(message) { }
        public ProductArgumentException(string message, Exception inner) : base(message, inner) { }
    }
}
