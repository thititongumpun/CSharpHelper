using System;
using System.Linq;

namespace UtilsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "eiei";
            person.Age = 28;
            // string res = StingHelper.ConvertToString(person);

            Console.WriteLine(person);

            Console.WriteLine(person.GetFullName());

            // System.Console.WriteLine(StingHelper.ConvertToString(person));
        }
    }
}
