using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPExercice.Logic
{
    public abstract class Product : IProduct
    {
        private float _discountPercentaje;
        private float _taxPercentaje;
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public float DiscountPercentaje { get; set; }
        public float TaxPercentaje { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\n\t" +
                $"% Discount.............: {DiscountPercentaje,18:P2}\n\t" +
                $"% Tax..................: {TaxPercentaje,18:P2}\t";
        }
        public abstract decimal CalculateDiscount();
        public abstract decimal CalculateTax();
        public abstract decimal CalculateValueToPay();
        private abstract float ValidatePercentaje(float value)
        {
            if(DiscountPercentaje != 0)
            {
                throw new ArgumentException("");
            }
            return value;
        }
    }
}