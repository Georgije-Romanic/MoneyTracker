using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    class person
    {
        
        class Person
        {
            public int Alter { get; set; }

            public Person(string fn, string ln)
            {
                First = fn;
                Last = ln;
            }
            public string First { get; }
            public string Last { get; }
        }
    }
}
