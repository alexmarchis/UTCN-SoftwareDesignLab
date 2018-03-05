using System.Collections.Generic;

namespace SOLID.OpenClosed
{
    class Product
    {
        public decimal Price { get; set; }
        public List<ProductTaxType> Taxes { get; set; }
    }
}
