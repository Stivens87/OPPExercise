namespace OOPExercice.Logic
{
    public class FixedPriceProduct : Product
    {
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Price..................: {Price,18:C2}\n\t" +
                $"Discount value.........: {CalculateDiscount(),18:C2}\n\t" +
                $"Tax value..............: {CalculateTax(),18:C2}\n\t" +
                $"Value to pay...........: {CalculateValueToPay(),18:C2}";
        }
        public override decimal CalculateValueToPay()
        {
            return Price - ((decimal)DiscountPercentaje * Price) + ((decimal)TaxPercentaje * Price);
        }

        public override decimal CalculateDiscount()
        {
            return (decimal)DiscountPercentaje * Price;
        }
        public override decimal CalculateTax()
        {
            return (decimal)TaxPercentaje * Price;
        }
        private float ValidateGreatherThanZero(decimal value)
        {
            return (float)value;
        }
    }
}

