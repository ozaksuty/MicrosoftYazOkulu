using Newtonsoft.Json;
using ServiceApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Data
{
    public class ServiceManager
    {
        const string Url = "Buraya WebService url gelecek! :)";
        const string insert = "insert";
        const string update = "update";
        const string delete = "delete";
        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        private async Task<MobileResult> Process(StudentModel model,
            string processType)
        {
            HttpClient client = await GetClient();
            var response = await client.PostAsync(Url + processType,
                new StringContent(
                    JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"));
            var result = JsonConvert.DeserializeObject<MobileResult>(
                await response.Content.ReadAsStringAsync());
            return result;
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            HttpClient client = await GetClient();
            string result = await client.GetStringAsync(Url + "getall");
            var mobileResult = JsonConvert.DeserializeObject<MobileResult>(result);
            return JsonConvert.DeserializeObject<IEnumerable<StudentModel>>(mobileResult.Data.ToString());
        }

        public async Task<MobileResult> Add(StudentModel model)
        {
            return await Process(model, insert);
        }

        public async Task<MobileResult> Delete(StudentModel model)
        {
            return await Process(model, delete);
        }
    }
}