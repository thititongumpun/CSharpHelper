using System;

namespace UtilsCSharp
{
    public class Person
    {
        public string Name { get;set; }
        public int Age { get;set; }

        public override string ToString()
        {
            return Name + "," + Age.ToString();
        }

        public string GetFullName()
        {
            return Name + Age.ToString();
        }
    }
}