using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.Builder
{
    /// <summary>
    /// Builder style.  use to allow for creation of immutable objects
    /// </summary>
    public sealed class UsesBuilder1
    {
        private readonly string name;

        public string Name { get { return name; } }
        /// <summary>
        /// You will construct using the builder class
        /// </summary>
        private UsesBuilder1(Builder builder)
        {
            this.name = builder.Name;
        }

        //Can add factory creation methods as well..
        public static UsesBuilder1 FromName(String name)
        {
            //then either go through builder, or add new private constructor to use...
            return new UsesBuilder1.Builder { Name = name }.Build();
        }

        public sealed class Builder
        {
            public string Name { get; set; }

            public UsesBuilder1 Build()
            {
                return new UsesBuilder1(this);
            }
        }


    }

    /// <summary>
    /// More efficient builder style
    /// </summary>
    public sealed class UsesBuilder2
    {
        private string name;
        private UsesBuilder2(Builder builder)
        { }

        public sealed class Builder
        {
            private UsesBuilder2 foo;
            public string Name
            {
                get { return foo.name; }
                set { foo.name = value; }
            }
            public UsesBuilder2 Build()
            {
                UsesBuilder2 copy = foo;
                foo = null;
                return copy;
            }
        }
    }
}
