using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using WinForm.EntityClass;

namespace WinForm.Service
{
    class GoodService
    {
        private static String serverAddress = "http://localhost:5001/"; //服务器地址
        //查询全部商品
        public static List<Good> GetAllGoods()
        {
            string baseUrl = serverAddress + "Good?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<Good> goods = JsonConvert.DeserializeObject<List<Good>>(task.Result);
            return goods;
        }
        //根据ID查询商品
        public static Good GetGoodByGoodId(int goodId)
        {
            string baseUrl = serverAddress + "Good/getGoodById?" +
                "GoodId=" + goodId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            Good good = JsonConvert.DeserializeObject<Good>(task.Result);
            return good;
        }
        //根据商品名查询商品
        public static List<Good> GetGoodByGoodName(string goodName)
        {
            string baseUrl = serverAddress + "Good/getGoodByName?" +
                "GoodName=" + goodName;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<Good> goods = JsonConvert.DeserializeObject<List<Good>>(task.Result);
            return goods;
        }
        //根据用户名查询商品
        public static List<Good> GetGoodByUsername(string username)
        {
            string baseUrl = serverAddress + "Good/getGoodByUsername?" +
                "Username=" + username;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<Good> goods = JsonConvert.DeserializeObject<List<Good>>(task.Result);
            return goods;
        }
        //发布商品
        public static bool AddPost(Good good)
        {
            string baseUrl = serverAddress + "Good/addGood?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(good),
                Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }
        //删除商品
        public static void DeletePost(int userId, int goodId)
        {
            string baseUrl = serverAddress + "Good/deletePost?" + "userId=" + userId + "&&GoodId=" + goodId; ;
            HttpClient client = new HttpClient();

            var task = client.DeleteAsync(baseUrl);
            task.Wait();
            return;
        }

        //修改商品
        public static void AlterPost(int goodId, Good good)
        {
            string baseUrl = serverAddress + "Good/alterPost?" + "GoodId=" + goodId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(good),
                Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
            return;
        }

    }
}

