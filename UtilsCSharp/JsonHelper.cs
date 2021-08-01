namespace UtilsCSharp
{
    public static class JsonHelper
    {
        public static string JsonResult(Object object)
        {
            return JsonConvert.SerializeObject(object, Formatting.Indented);
        }
    }
}