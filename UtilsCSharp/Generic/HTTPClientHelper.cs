using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UtilsCSharp.Generic
{
    public interface IHTTPClientHelper
    {
        Task<T> GetAsync<T>(string url);
        Task<T> PostAsync<T>(string url, HttpContent contentObj);
        Task<T> PutAsync<T>(string url, HttpContent contentObj);
        Task<T> DeleteAsync<T>(string url);
    }
    public class HTTPClientHelper : IHTTPClientHelper
    {
        IHttpClientFactory httpClientFactory;
        HttpClient client;
        string ClientName;

        public HTTPClientHelper(IHttpClientFactory httpClientFactory, string ClientName)
        {
            this.httpClientFactory = httpClientFactory;
            this.ClientName = ClientName;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    string d = await content.ReadAsStringAsync();
                    if (d != null)
                    {
                        data = JsonConvert.DeserializeObject<T>(d);
                        return (T)data;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Object o = new Object();
            return (T)o;
        }

        public async Task<T> PostAsync<T>(string url, HttpContent contentObj)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);
            using (HttpResponseMessage response = await client.PostAsync(url, contentObj))
            using (HttpContent content = response.Content)
            {
                string d = await content.ReadAsStringAsync();
                if (d != null)
                {
                    data = JsonConvert.DeserializeObject<T>(d);
                    return (T)data;
                }
            }
            Object o = new Object();
            return (T)o;
        }

        public async Task<T> PutAsync<T>(string url, HttpContent contentObj)
        {
            T data;
            client = httpClientFactory.CreateClient(ClientName);

            using (HttpResponseMessage response = await client.PutAsync(url, contentObj))
            using (HttpContent content = response.Content)
            {
                string d = await content.ReadAsStringAsync();
                if (d != null)
                {
                    data = JsonConvert.DeserializeObject<T>(d);
                    return (T)data;
                }
            }
            Object o = new Object();
            return (T)o;
        }

        public async Task<T> DeleteAsync<T>(string url)
        {
            T newT;
            client = httpClientFactory.CreateClient(ClientName);

            using (HttpResponseMessage response = await client.DeleteAsync(url))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    newT = JsonConvert.DeserializeObject<T>(data);
                    return newT;
                }
            }
            Object o = new Object();
            return (T)o;
        }
    }
}