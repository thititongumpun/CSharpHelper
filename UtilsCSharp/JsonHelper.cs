using System;
using Newtonsoft.Json;

namespace UtilsCSharp
{
    public static class JsonHelper
    {
        public static string JsonResult(Object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}