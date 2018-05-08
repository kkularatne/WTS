using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WTS.Web.DTOs;

namespace WTS.Web.Pages
{
    public class AboutModel : PageModel
    {
        private readonly IWTSAPI wTSAPI;
        private const string api_end_point = "api/Employee";

        public List<EmployeeDto> employeeDtos { get; set; }


        public AboutModel(IWTSAPI wTSAPI)
        {
            this.wTSAPI = wTSAPI;
        }

        public void OnGet()
        {
            employeeDtos = getEmployeeDtosAsync().Result;
        }

        private async Task<List<EmployeeDto>> getEmployeeDtosAsync()
        {
            List<EmployeeDto> dto = new List<EmployeeDto>();

            HttpClient client = wTSAPI.InitializeClient();

            HttpResponseMessage res = await client.GetAsync(api_end_point);

            //Checking the response is successful or not which is sent using HttpClient    
            if (res.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api     
                var result = res.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list    
                dto = JsonConvert.DeserializeObject<List<EmployeeDto>>(result);

            }

            return dto;
        }
    }
}
