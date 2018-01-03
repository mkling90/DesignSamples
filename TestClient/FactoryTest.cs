using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleClasses.FactoryPattern;

namespace TestClient
{
    [TestFixture]
    public class FactoryTest
    {
        [Test]
        public void FromSeconds()
        {
            BadDuration duration = BadDuration.FromSeconds(20);
            Assert.AreEqual(20000000, duration.Ticks);
        }

    }
}
