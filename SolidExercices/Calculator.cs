using System.Collections.Generic;

namespace SolidExercices
{

    public class Calculator
    {
        private readonly List<IOperateur> _operateurs = new List<IOperateur>() { new Sum(), new Substraction(), new Product(), new Division() };
        
        public decimal Calculate(string operation)
        {
            decimal result = 0;

            foreach (var operateur in _operateurs)
            {
                if (operateur.CanCalculate(operation))
                {
                    result = operateur.Calculate(operation);
                }
            }

            return result;
        }
    }
}