using System;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        private Operateurs _operateurs;

        [SetUp]
        public void Init()
        {
            _operateurs = new Operateurs();
        }

        [Test]
        public void CalculateASum()
        {
            _operateurs.Add(new Sum());
            var calculator = new Calculator(_operateurs);

            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(Convert.ToDecimal(3.3));
        }

        [Test]
        public void ThrowAnArgumentException()
        {
            var calculator = new Calculator(_operateurs);
            Check.ThatCode(() => calculator.Calculate("1+2,3")).Throws<ArgumentException>().WithMessage("Aucun opérateur ne permet de calculer 1+2,3");
        }
        

        [Test]
        public void CalculateASubstraction()
        {
            _operateurs.Add(new Substraction());
            var calculator = new Calculator(_operateurs);
            var result = calculator.Calculate("8-2,3");
            Check.That(result).IsEqualTo(Convert.ToDecimal(5.7));
        }

        [Test]
        public void CalculateAProduct()
        {
            _operateurs.Add(new Product());
            var calculator = new Calculator(_operateurs);
            var result = calculator.Calculate("4*2,5");
            Check.That(result).IsEqualTo(Convert.ToDecimal(10.0));
        }

        [Test]
        public void CalculateADivision()
        {
            _operateurs.Add(new Division());
            var calculator = new Calculator(_operateurs);
            var result = calculator.Calculate("1/4");
            Check.That(result).IsEqualTo(Convert.ToDecimal(0.25));
        }

        [Test]
        public void CalculateADivisionByZero()
        {
            _operateurs.Add(new Division());
            var calculator = new Calculator(_operateurs);
            Check.ThatCode(() => calculator.Calculate("1/0")).Throws<DivideByZeroException>();
        }
    }
}
