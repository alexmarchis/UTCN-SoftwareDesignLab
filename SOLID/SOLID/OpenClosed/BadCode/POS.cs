namespace SOLID.OpenClosed.BadCode
{
    class POS
    {
        public decimal CalculatePrice(Product product)
        {
            return product.Price - CalculateTax(product);
        }

        private decimal CalculateTax(Product product)
        {
            decimal totalTax = 0;
            foreach (ProductTaxType taxType in product.Taxes)
            {
                switch (taxType)
                {
                    case ProductTaxType.VAT:
                        totalTax += product.Price * 0.19m;
                        break;
                    case ProductTaxType.Region:
                        totalTax += product.Price * 0.05m;
                        break;
                }
            }

            return totalTax;
        }
    }
}
