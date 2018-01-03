using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleClasses.StrategyPattern;

namespace TestClient
{
    [TestFixture]
    public class StrategyDecoratorTest
    {
        public static readonly ReadOnlyCollection<Person> People = new List<Person>
        {
            new Person { Name = "Jon", Age = 35},
            new Person { Name = "Rob", Age = 44},
            new Person { Name = "Holly", Age = 36},
            new Person { Name = "Tom", Age = 8}
        }.AsReadOnly();

        [Test]
        public void testStrategy()
        {
            var list = People.ToList();
            //Sort doesn't care what the implementation is - they just care about contract
            list.Sort((x, y) => x.Age.CompareTo(y.Age));
            list.Sort(Strategy.CompareByAge);
            list.Sort(new Strategy.AgeComparer());
        }

        [Test]
        public void testStrategyDecorator()
        {
            var list = People.ToList();
            list.Sort(new LoggingComparer<Person>(new Strategy.AgeComparer())); 
        }

        [Test]
        public void testStrategyDecorator2()
        {
            // Using the non-generic logger
            var list = People.ToList();
            list.Sort(LoggingComparer.For(new Strategy.AgeComparer()));
        }

    }
}
