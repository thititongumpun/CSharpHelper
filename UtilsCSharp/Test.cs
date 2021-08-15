using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

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

    public class ErrorLogResponse<T>
    {
      [JsonProperty("datetime")]
      private string DateTime;
      [JsonProperty("body")]
      public T Body { get; set; }
      [JsonProperty("type")]
      public string Type { get; set; }
      [JsonProperty("message")]
      public string Message { get; set; }
      [JsonProperty("stracktrace")]
      public string StackTrace { get; set; }

      public string dateTime
      {
        get => DateTime;
        set => DateTime = value;
      }

      public ErrorLogResponse(string dateTime, T body, Exception ex)
      {
        DateTime = $"Exception Details on {dateTime}";
        Body = body;
        Type = ex.GetType().Name;
        Message = ex.Message;
        StackTrace = ex.ToString();
      }

      public ErrorLogResponse(string dateTime, T body)
      {
        DateTime = $"Exception Details on {dateTime}";
        Body = body;
      }
    }
  }
}