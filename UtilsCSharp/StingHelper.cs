namespace UtilsCSharp
{
    public static class StingHelper
    {
        public static string ConvertToString(object d)
        {
            string result = d.ToString();

            if (d != null) result = d.ToString();

            return result;
        }
    }
}