using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Decorator - dynamically adding behavior at execution time
/// </summary>
namespace SampleClasses.StrategyPattern
{
    public class LoggingComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> _comparer;
        public LoggingComparer(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public int Compare(T x, T y)
        {
            int result = _comparer.Compare(x, y);
            //Adding functionality to comparison behavior..
            Console.WriteLine($"Compare({x}, {y}) == {result}");
            return result;
        }
    }

    /// <summary>
    /// This class helps you  not have to explictly declare the logging type..
    /// new LoggingComparer<Person>(new Strategy.AgeComparer()));
    /// instead use
    /// LoggingComparer.For(new Strategy.AgeComparer())
    /// </summary>
    public static class LoggingComparer
    {
        public static IComparer<T> For<T>(IComparer<T> comparer)
        {
            return new LoggingComparer<T>(comparer);
        }
    }
}
