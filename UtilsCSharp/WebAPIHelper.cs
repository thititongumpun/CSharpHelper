// using System.IO;
// using System.Net;

// namespace UtilsCSharp
// {
//     public class WebAPIHelper
//     {

//         public static T PostJSONData<T>(string destinationUrl, object obj, int? timeout = null)
//         {
//             string req = JsonConvert.SerializeObject(obj);

//             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
//             byte[] bytes = System.Text.Encoding.UTF8.GetBytes(req);
//             request.ContentType = "application/json";
//             request.ContentLength = bytes.Length;
//             request.Method = "POST";
//             request.Accept = "application/json";
//             if (timeout != null) request.Timeout = timeout.GetValueOrDefault();

//             request.Headers.Add("Accept-Language", Thread.CurrentThread.CurrentUICulture.Name);

//             using (Stream requestStream = request.GetRequestStream())
//             {
//                 requestStream.Write(bytes, 0, bytes.Length);
//                 using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
//                 {
//                     if (response.StatusCode == HttpStatusCode.OK)
//                     {
//                         using (Stream responseStream = response.GetResponseStream())
//                         {
//                             using (StreamReader streamReader = new StreamReader(responseStream))
//                             {
//                                 return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
//                             }
//                         }
//                     }
//                 }
//             }
//             return default(T);
//         }
//         public static T GetJSONData<T>(string destinationUrl, string tokenKey = null, string UILanguage = null, bool isproxy = false)
//         {
//             // string req = JsonConvert.SerializeObject(obj);

//             HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
//             //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(req);
//             //request.ContentType = "application/json";
//             //request.ContentLength = bytes.Length;
//             //request.Method = "POST";
//             //request.Accept = "application/json";

//             if (!string.IsNullOrEmpty(UILanguage))
//             {
//                 request.Headers.Add(string.Format("Accept-Language:{0}", UILanguage));
//             }

//             if (!string.IsNullOrEmpty(tokenKey))
//             {
//                 //string header = string.Format(@""Authorization\", \"JWT\ " + \"{0}\"", tokenKey);
//                 request.Headers.Add("Authorization", "JWT " + tokenKey);
//             }
//             //using (Stream requestStream = request.GetRequestStream())
//             //{
//             //    requestStream.Write(bytes, 0, bytes.Length);

//             if (isproxy)
//             {
//                 request.Proxy = new WebProxy(ConfigurationManager.AppSettings["PROXY_SERVER"], Convert.ToInt32(ConfigurationManager.AppSettings["PROXY_PORT"]))
//                 {
//                     Credentials = new NetworkCredential()
//                     {
//                         UserName = ConfigurationManager.AppSettings["PROXY_USER"],
//                         Password = ConfigurationManager.AppSettings["PROXY_PASS"]
//                     }
//                 };
//             }

//             using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
//             {
//                 if (response.StatusCode == HttpStatusCode.OK)
//                 {
//                     using (Stream responseStream = response.GetResponseStream())
//                     {
//                         using (StreamReader streamReader = new StreamReader(responseStream))
//                         {
//                             return JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
//                         }
//                     }
//                 }
//             }
//             return default(T);
//         }
//     }
// }