﻿namespace MoneyTracker
{
    class person
    {

        class Person
        {
            public int Alter { get; set; }

            public Person(string firstname, string lastname)
            {
                First = firstname;
                Last = lastname;
            }

            public string First { get; }
            
            public string Last { get; }
        }
    }
}