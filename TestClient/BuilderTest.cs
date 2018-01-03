using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleClasses.Builder;
namespace TestClient
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void BuildTest()
        {
            var b1 = new UsesBuilder1.Builder { Name = "MyPeriod" }.Build();
            var b2 = new UsesBuilder2.Builder { Name = "MyPeriod" }.Build();

        }
    }
}
