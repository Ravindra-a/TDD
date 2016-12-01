using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Tests
{
    [Category("Application.Domain")]
    [TestFixture]
    public class DomainTestFixture
    {
        [Test]
        public void FirstTest()
        {
            int result = 10 - 6;
            Assert.AreEqual(4, result);
        }
    }
}
