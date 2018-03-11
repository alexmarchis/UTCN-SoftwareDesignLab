namespace SOLID.OpenClosed.GoodCode
{
    class POS
    {
        private ITaxCalculator[] taxCalculators;

        public POS(ITaxCalculator[] taxCalculators)
        {
            this.taxCalculators = taxCalculators;
        }

        public decimal CalculatePrice(Product product)
        {
            return product.Price - CalculateTax(product);
        }

        private decimal CalculateTax(Product product)
        {
            decimal totalTax = 0;
            foreach (ProductTaxType tax in product.Taxes)
            {
                foreach (ITaxCalculator taxCalculator in taxCalculators)
                {
                    if (taxCalculator.IsTaxApplicable(tax))
                    {
                        totalTax += taxCalculator.CalculateTax(product);
                    }
                }
            }

            return totalTax;
        }
    }
}
