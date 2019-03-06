using Employees.Core.Contracts;
using Employees.Core.Dtos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Employees.Infrastructure
{
    public class EmployeesUtility : IEmployeesUtility
    {
        private string employeesApiUrl = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        public IEnumerable<EmployeeApi> GetEmployeesApi()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var webResponse = client.DownloadString(employeesApiUrl);
                var result = JsonConvert.DeserializeObject<List<EmployeeApi>>(webResponse);
                if (result.Any())
                {
                    return result;
                }
            }

            return null;
        }
    }
}
