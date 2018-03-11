namespace SOLID.OpenClosed.GoodCode
{
    internal interface ITaxCalculator
    {
        bool IsTaxApplicable(ProductTaxType taxType);
        decimal CalculateTax(Product product);
    }

    class RegionTaxCalculator : ITaxCalculator
    {
        public bool IsTaxApplicable(ProductTaxType taxType)
        {
            return taxType == ProductTaxType.Region;
        }

        public decimal CalculateTax(Product product)
        {
            return product.Price * 0.05m;
        }
    }
}