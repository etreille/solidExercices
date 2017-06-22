using System;
using System.Linq;

namespace SolidExercices
{
    public class Product : IOperateur
    {
        public bool CanCalculate(string operation)
        {
            return operation.Contains("*");
        }

        public decimal Calculate(string operation)
        {
            var nombres = operation.Split('*');
            return nombres.Select(Convert.ToDecimal).Aggregate((workingNumber, next) => workingNumber * next); 
        }
    }
}