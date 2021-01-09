namespace MoneyTracker
{
    class person
    {

        class Person
        {
            //

            public int Alter { get; set; }

            public Person(string first, string last)
            {
                First = first;
                Last = last;
            }

            public string First { get; }
            
            public string Last { get; }
        }
    }
}
