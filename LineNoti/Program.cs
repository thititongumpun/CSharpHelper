using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
namespace LineNoti
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            lineNotify(JsonSerializer.Serialize(hello));
        }

        private class Hello
        {
            public string name { get; set; } = "suwit";
            public int age { get; set; } = 12;
        }

        private static void lineNotify(string msg)
        {
            string token = "apiKey";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                var postData = string.Format("message={0}", msg);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
