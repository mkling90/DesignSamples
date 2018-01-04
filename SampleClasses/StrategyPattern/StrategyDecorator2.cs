using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SampleClasses.StrategyPattern
{

    public class Strategy2
    {

        public class AgeComparer : IComparer<Person>
        {
            //Note:  only virtual for the bad example below.
            public virtual int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

        /// <summary>
        /// Sample Decorator style, using inheritance to directly overwrite
        /// Downside:  Requires original method to be virtual, assuming that the original author
        /// knew which methods who would be override
        /// Do NOT use.  Use Composition method instead.
        /// </summary>
        public class LoggingAgeComparerBad : AgeComparer
        {
            public override int Compare(Person x, Person y)
            {
                int result = base.Compare(x, y);
                //Does not actually care WHICH comparer, since we're just adding to it.
                Console.WriteLine($"Compare({x}, {y}) == {result}"); 
                return result;
            }
        }

    }
}
