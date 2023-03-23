namespace OOPExercice.Logic
{
    public class VariablePriceProduct : Product
    {
        private decimal _pricePerUnitOfMeasure;
        private decimal _quantity;
        public decimal PricePerUnitOfMeasure
        {
            get => _pricePerUnitOfMeasure;
            set => _pricePerUnitOfMeasure = value;
        }
        public decimal Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
        public String? UnitOfMeasure { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Unit of Measure........: {UnitOfMeasure}\n\t" +
                $"Quantity...............: {Quantity,18}\n\t" +
                $"Price..................: {PricePerUnitOfMeasure,18:C2}\n\t" +
                $"Discount value.........: {CalculateDiscount(),18:C2}\n\t" +
                $"Tax value..............: {CalculateTax(),18:C2}\n\t" +
                $"Value to pay...........: {CalculateValueToPay(),18:C2}";
        }
        public override decimal CalculateDiscount()
        {
            return ((decimal)DiscountPercentaje * PricePerUnitOfMeasure) * Quantity;
        }
        public override decimal CalculateTax()
        {
            return ((decimal)TaxPercentaje * PricePerUnitOfMeasure) * Quantity;
        }
        public override decimal CalculateValueToPay()
        {
            return (PricePerUnitOfMeasure * Quantity) - CalculateDiscount() + CalculateTax();
        }
        /* private float ValidateGreatherThanZero(decimal value1)
        {
            return (float)value1;
        }*/
    }
}
