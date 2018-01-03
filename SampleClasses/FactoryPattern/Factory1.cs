using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.FactoryPattern
{
    /// <summary>
    /// Basic immutable type
    /// </summary>
    public sealed class Point
    {
        private readonly int x1;
        private readonly int y1;

        public int X { get { return x1; } }
        public int Y { get { return y1; } }

        public Point(int x, int y)
        {
            this.x1 = x;
            this.y1 = y;
        }
    }

    public class BadDuration
    {
        private readonly long ticks;

        public long Ticks { get { return ticks; } }
        public BadDuration(long ticks)
        {
            this.ticks = ticks;
        }

        /* public BadDuration(long milliseconds)
         {
             this.ticks = milliseconds * 1000;
         }

         public BadDuration(long seconds)
         {
             this.ticks = seconds * 1000 * 1000;
         }
         */

        #region Contructor Overload Solution
        //  Note -> if using this method, should make the constructor
        // private so the user MUST use the factory methods
        public static BadDuration FromMilliseconds(long milliseconds)
        {
            return new BadDuration(milliseconds * 1000);
        }

        public static BadDuration FromSeconds(long seconds)
        {
            return new BadDuration(seconds * 1000 * 1000);
        }
        #endregion
    }

}
