namespace SOLID.OpenClosed.GoodCode
{
    class VatTaxCalculator : ITaxCalculator
    {
        public bool IsTaxApplicable(ProductTaxType taxType)
        {
            return taxType == ProductTaxType.VAT;
        }

        public decimal CalculateTax(Product product)
        {
            return product.Price * 0.19m;
        }
    }
}