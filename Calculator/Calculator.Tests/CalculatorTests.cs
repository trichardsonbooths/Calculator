using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;
namespace Calculator.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void result_returns_correct_sum_from_adding_two_numbers()
        {
            var result = new Calculator(1, 1).Addition();

            Assert.AreEqual(2, result);
        }

        [Test]
        public void result_returns_correct_sum_from_subtracting_two_numbers()
        {
            var result = new Calculator(10, 1).SubTraction();

            Assert.AreEqual(9, result);
        }

        [Test]
        public void result_returns_correct_sum_from_adding_two_numbers_2_shouldFAIL()
        {
            var result = new Calculator(10, 1).SubTraction();

            Assert.AreEqual(10, result);
        }
    }
}
