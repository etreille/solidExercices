using System;
using System.Collections.Generic;

namespace SolidExercices
{

    public class Calculator
    {
        private readonly Operateurs _operateurs;

        public Calculator(Operateurs operateurs)
        {
            _operateurs = operateurs;
        }

        public decimal Calculate(string operation)
        {

            for (var i = 0; i < _operateurs.Count(); i++)
            {
                if (_operateurs.Current.CanCalculate(operation))
                {
                    return _operateurs.Current.Calculate(operation);
                }
                _operateurs.NextOperateur();
            }
            throw new ArgumentException("Aucun opérateur ne permet de calculer "+operation);
        }

    }
}