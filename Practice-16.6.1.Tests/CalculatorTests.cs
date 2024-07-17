using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Practice_16._6._1;

namespace Practice_16._6._1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void Additional_MustReturnsTrueValue()
        {
            Assert.That(calculator.Additional(200, 300) == 500);
        }

        [Test]
        public void Subtraction_MustReturnsTrueValue()
        {
            Assert.That(calculator.Subtraction(500, 300) == 200);
        }

        [Test]
        public void Miltiplication_MustReturnsTrueValue()
        {
            Assert.That(calculator.Miltiplication(200, 5) == 1000);
        }

        [Test]
        public void Division_MustReturnsTrueValue()
        {
            Assert.That(calculator.Division(1000, 100) == 10);
        }
    }
}
