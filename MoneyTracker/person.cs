namespace MoneyTracker
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

            public string First { get; internal set; }
            
            public string Last { get; internal set; }
        }
    }
}