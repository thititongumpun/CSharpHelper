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
            // 0
            // 4321
            // 5760
            DateTime paymentDate = new DateTime(2021, 01, 19, 00, 58, 00 );
            DateTime createDate =  new DateTime(2021, 01, 15, 15, 59, 53 );
            TimeSpan ts = paymentDate.Subtract(createDate);
            // Console.WriteLine(dt1);
            // Console.WriteLine(dt2);
            Console.WriteLine(Math.Ceiling(ts.TotalMinutes));
            Console.WriteLine("No. of Minutes (Difference) = {0}", Math.Ceiling(ts.TotalMinutes));
            Console.WriteLine(DateTime.Now);

        }

        private static double CalculateTax(double val, out double total)
        {
            return total = Math.Round(val * 0.7);
        }

        private static string GetFullName(string f, string l)
        {
            return $"{f} {l}";
        }
    }
}
