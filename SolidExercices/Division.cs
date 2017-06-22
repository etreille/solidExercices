using System;
using System.Linq;

namespace SolidExercices
{
    internal class Division : IOperateur
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
                Console.WriteLine("Division par zéro impossible " + e.Message);
                return 0;
            }
        }
    }
}