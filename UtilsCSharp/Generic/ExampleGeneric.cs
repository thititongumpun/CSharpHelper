using System;

namespace UtilsCSharp.Generic
{
    public class ExampleGeneric
    {
        public static T Larger<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}