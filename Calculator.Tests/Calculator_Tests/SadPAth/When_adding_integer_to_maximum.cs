using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator.Domain;

namespace Calculator.Tests.Calculator_Tests.SadPAth
{
    [Category("Exception handling")]
    [TestFixture]
    public class When_adding_integer_to_maximum
    {
        SimpleCalculator _simpleCalculator;

        [SetUp]
        public void AssignVariables()
        {
            _simpleCalculator = new SimpleCalculator();
        }

        [Test]
        public void Method_should_throw_not_supported_exception()
        {
            Assert.That(() => _simpleCalculator.Add(int.MaxValue, 3), Throws.TypeOf<NotSupportedException>());
        }
    }
}
