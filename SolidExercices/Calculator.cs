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
            else if (operation.Contains("-"))
            {
                var nombres = operation.Split('-');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber - next);
            }
            else if (operation.Contains("*"))
            {
                var nombres = operation.Split('*');
                result =
                    nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber * next);
            }
            else if (operation.Contains("/"))
            {
                try
                {
                    var nombres = operation.Split('/');
                    result =
                        nombres.Select(Convert.ToDouble).Aggregate((workingNumber, next) => workingNumber / next);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Division par zéro impossible "+e.Message);
                }
            }

            return result;
        }
    }
}