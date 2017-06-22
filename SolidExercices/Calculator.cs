using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            Double result = 0;
            if (operation.Contains("+"))
            {
                var nombres = operation.Split('+');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber + next);
            }
            if (operation.Contains("-"))
            {
                var nombres = operation.Split('-');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber - next);
            }
            if (operation.Contains("*"))
            {
                var nombres = operation.Split('*');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber * next);
            }
            if (operation.Contains("/"))
            {
                var nombres = operation.Split('/');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber / next);
            }

            return result;
        }
    }
}