using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForm.EntityClass;
using WinForm.Tool;

namespace WinForm.Service
{
    class CollectService
    {
        private static String serverAddress = "http://localhost:5001/"; //服务器地址

        private static HttpClient client = new HttpClient();

        //添加收藏
        public static bool AddCollect(Collect collect)
        {
            string baseUrl = serverAddress + "Collect/AddCollect?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(collect),
                Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }

        //根据用户ID查询收藏的商品
        public static List<Good> GetCollects(int UserId)
        {
            string baseUrl = serverAddress + "Collect/getCollectGoods?userId="+StaticVar.USERID;
            var task = client.GetAsync(baseUrl);
            var response = task.Result;
            if (!response.IsSuccessStatusCode)
            {
                // 获取失败!
                return null;
            }
            return response.Content.ReadFromJsonAsync<List<Good>>().Result;
        }
    }
}
