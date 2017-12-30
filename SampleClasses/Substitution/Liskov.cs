using SampleClasses.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Substitution
{
   

    public class Liskov
    {
        public virtual string FormatPoint(int x, int y)
        {
            return string.Format("x ={0}; y={1};", x, y);
        }
        public virtual string FormatPoint(Point p)
        {
            return FormatPoint(p.X, p.Y);
        }
    }

    public class MyLiskov : Liskov
    {
        public override string FormatPoint(int x, int y)
        {
            return base.FormatPoint(x, y) + "<--";
        }
    }
    /// <summary>
    /// Open-Closed bad example
    /// </summary>
    public class Person
    {
        string name { get; set; }
        DateTime birthday { get; set; }
    }

    class Spy : Person
    {
        //if you need to hide the name, the design is wrong, should be subsitituable.
    }

  

    
}
