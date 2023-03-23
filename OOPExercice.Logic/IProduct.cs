using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercice.Logic
{
    internal interface IProduct
    {
        public decimal CalculateDiscount();
        public decimal CalculateTax();
        public decimal CalculateValueToPay();
    }
}
