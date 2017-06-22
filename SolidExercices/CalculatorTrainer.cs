using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private readonly string[] _operations = new[]
            {"1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", ""};

        private readonly Operateurs _operateurs = new Operateurs();

        public void Run()
        {
            _operateurs.Add(new Sum());
            _operateurs.Add(new Substraction());
            _operateurs.Add(new Product());
            _operateurs.Add(new Division());

            var calculator = new Calculator(_operateurs);
            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }
}
