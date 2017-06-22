using System;
using System.Linq;

namespace SolidExercices
{
    public class Division : IOperateur
    {
        public bool CanCalculate(string operation)
        {
            return operation.Contains("/");
        }

        public decimal Calculate(string operation)
        {
            try
            {
                var nombres = operation.Split('/');
                return nombres.Select(Convert.ToDecimal).Aggregate((workingNumber, next) => workingNumber / next);
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("Division par zéro impossible " + e.Message);
            }
        }
    }
}