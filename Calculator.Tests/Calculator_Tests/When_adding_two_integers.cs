using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator.Domain;

namespace Calculator.Tests
{
    [Category("Calculator.Domain")]
    [TestFixture(1, 1, 2)]
    [TestFixture(2, 2, 4)]
    [TestFixture(3, 2, 5)]
    [TestFixture(4, 4, 8)]
    [TestFixture(5, 6, 11)]
    [TestFixture(12, 10, 22)]
    [TestFixture(13, 14, 27)]
    [TestFixture(0, 0, 0)]
    //[TestFixture(int.MaxValue , 0 ,int.MaxValue)]
    public class When_adding_two_integers
    {
        SimpleCalculator _simpleCalculator;
        int _firstParameter;
        int _secondParameter;
        int _result;
        
        public When_adding_two_integers(int firstParameter,int secondParameter,int result)
        {
            _firstParameter = firstParameter;
            _secondParameter = secondParameter;
            _result = result;
        }

        [SetUp]
        public void ExecuteBefore()
        {
            _simpleCalculator = new SimpleCalculator();
        }
        [Test]
        public void Then_sum_is_correct()
        {
            CalculationResult calculationResult = _simpleCalculator.Add(_firstParameter, _secondParameter);
            Assert.AreEqual(_result, calculationResult.OutCome);
        }
    }
}
