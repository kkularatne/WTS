using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WTS.Web
{
    public class WTSAPI : IWTSAPI
    {
        private readonly IConfiguration Configuration;        

        public WTSAPI(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public HttpClient InitializeClient()
        {
            string _apiBaseURI = Configuration["Api:BaseURL"];
            var client = new HttpClient();
            //Passing service base url    
            client.BaseAddress = new Uri(_apiBaseURI);

            client.DefaultRequestHeaders.Clear();
            //Define request data format    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
