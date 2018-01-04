using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SampleClasses.StrategyPattern
{
    /// <summary>
    /// Strategy Pattern - Separating concerns
    /// 9more of a "good practice" then a true pattern...
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Age);
        }
    }

    public class Strategy
    {
        //Comparison methods do not do sorting...
        // Sorting does not know anything about how comparison is done
        public static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public class AgeComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

    }
}
