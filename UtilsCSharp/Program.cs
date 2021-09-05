using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UtilsCSharp.Generic;

namespace UtilsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Person person = new Person();
            // person.Name = "eiei";
            // person.Age = 28;
            // string res = StingHelper.ConvertToString(person);

            // Console.WriteLine(person);

            // Console.WriteLine(person.GetFullName());

            // int result = ExampleGeneric.Larger<int>(3, 5);
            

            // Console.WriteLine(result);
            // StringBuilder sb = new StringBuilder();
            // string text = "Your Welcome";
            // int tierId = 1;
            // int platformId = 2;

            // sb.Append(text).Append('/').Append(tierId).Append('/').Append(platformId);
            // Console.WriteLine(sb.ToString());

            // var stopwatch = new Stopwatch();

            // stopwatch.Start();
            // for (int i = 0; i < 500; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // stopwatch.Stop();

            // var elapsed = stopwatch.ElapsedMilliseconds;
            // Console.WriteLine(elapsed);
            Console.WriteLine(CalculateTax(10000, out double total));
            Console.WriteLine(total);
        }

        private static double CalculateTax(double val, out double total)
        {
            return total = Math.Round(val * 0.7);
        }
    }
}
