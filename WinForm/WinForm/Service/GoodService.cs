using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace WinForm.Service
{
    class GoodService
    {
        private static String ServerAddress = "http://localhost:5001/";

        public static bool AddGood(Good good)
        {
            HttpClient client1 = new HttpClient();
            client1.DefaultRequestHeaders.Accept.Clear();
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(good),
                Encoding.UTF8, "application/json");
            var task = client1.PostAsync(ServerAddress + "/Good/addGood", content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }
    }
}
