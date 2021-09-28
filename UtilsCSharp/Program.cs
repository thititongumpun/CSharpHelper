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
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2021, 1, 8, 18, 6, 0 );
            TimeSpan ts = dt1 - dt2;
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine("No. of Minutes (Difference) = {0}", Math.Ceiling(ts.TotalMinutes));
        }

        private static double CalculateTax(double val, out double total)
        {
            return total = Math.Round(val * 0.7);
        }
    }
}
