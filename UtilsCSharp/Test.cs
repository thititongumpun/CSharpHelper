using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UtilsCSharp
{
    public class Test
    {
        
        public static void CalculateCool()
        {
            try
            {
                Console.Write("Enter a string - ");
                string i = Console.ReadLine();
                int intIntput = Convert.ToInt32(i);
                Console.WriteLine("You entered {0}", intIntput);
                if (intIntput > 1)
                {
                    Console.WriteLine("cool");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().ToString());
                Console.WriteLine(ex.GetType().Name.ToString());
                Console.WriteLine(ex.StackTrace.Substring(ex.StackTrace.Length - 8, 8));
                Console.WriteLine(new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName());
                Console.WriteLine(GetCurrentMethod());
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }
    }
}