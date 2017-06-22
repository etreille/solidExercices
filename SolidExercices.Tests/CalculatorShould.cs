using System;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }
        

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("8-2,3");
            Check.That(result).IsEqualTo(5.7);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4*2,5");
            Check.That(result).IsEqualTo(10.0);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1/4");
            Check.That(result).IsEqualTo(0.25);
        }

        [Test]
        public void CalculateADivisionByZero()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1/0");
            Check.ThatCode(() => { throw new DivideByZeroException(); }).Throws<DivideByZeroException>();
        }
    }
}
