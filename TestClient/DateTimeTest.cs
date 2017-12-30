using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    [TestFixture]
    public class DateTimeTest
    {
        [Test]
        public void DateKindMystery()
        {
            DateTime mystery = new DateTime(2017, 12, 25);
            Assert.AreEqual(DateTimeKind.Unspecified, mystery.Kind);
        }

        [Test]
        public void AreDatesEqual()
        {
            DateTime utc1 = new DateTime(2017, 11, 05, 7, 30, 0, DateTimeKind.Utc);
            DateTime utc2 = new DateTime(2017, 11, 05, 6, 30, 0, DateTimeKind.Utc);

            Assert.AreNotEqual(utc1, utc2);

            DateTime local1 = utc1.ToLocalTime();
            DateTime local2 = utc1.ToLocalTime();

            Assert.AreEqual(local1, local2);

            DateTime utc3 = local1.ToUniversalTime();
            DateTime utc4 = local2.ToUniversalTime();

            Assert.AreEqual(utc1, utc4);
        }
    }
}
