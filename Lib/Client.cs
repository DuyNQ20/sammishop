
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
namespace  Sammishop.Lib
{
    public class Client
    {
        static HttpClient client = new HttpClient();
        
        public static void Config()
        {
            client.BaseAddress = new Uri("http://localhost:56062");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void CheckDiscount()
        {
            Config();
            client.GetAsync("discount/check");
        }

        
    }
}
