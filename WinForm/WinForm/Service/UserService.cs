using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using WebApi.Models;

namespace WinForm.Service
{
    class UserService//用户访问服务器类 
    {
        private static string serverAddress = "http://localhost:5001/"; //服务器地址
        private static HttpClient client = new HttpClient();

        //使用TOKEN增加用户安全访问权限
        public static async Task<string> LoginUser(string username, string password)
        {
            string baseUrl = serverAddress + "User/login?" +
            "username=" + username + "&password=" + password;
            var respone = await client.GetAsync(baseUrl);
            if (respone.IsSuccessStatusCode)
            {
                var token = await respone.Content.ReadAsStringAsync();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                return token;
            }
            return "";
        }

        public static bool RegisterUser(User user_reg)
        {
            string baseUrl = serverAddress + "User/register?";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(user_reg), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }
        public static bool RegisterUser(string username, string sex, string password,
             string email, string phone)
        {
            string baseUrl = serverAddress + "User/register?";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            User user_reg = new User(username, sex, phone, password, email);

            HttpContent content = new StringContent(JsonConvert.SerializeObject(user_reg), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }

        public static User GetUser(string username)
        {
            string baseUrl = serverAddress + "User/getUser?" +
                "username=" + username;

            var task = client.GetAsync(baseUrl);
            var response = task.Result;
            if (!response.IsSuccessStatusCode)
            {
                // 获取失败!
                return null;
            }
            var user = response.Content.ReadFromJsonAsync<User>().Result;
            return user;
        }

        public static User GetUser(string username, string email, string phone)
        {
            string baseUrl = serverAddress + "User/forget?" +
                "username=" + username +
                "&&email=" + email +
                "&&phone=" + phone;

            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetAsync(baseUrl);
            var response = task.Result;
            if (!response.IsSuccessStatusCode)
            {
                // 获取失败!
                return null;
            }
            var user = response.Content.ReadFromJsonAsync<User>().Result;
            return user;
        }

        public static void ModifyUser(int userId, User user)
        {
            string baseUrl = serverAddress + "User/modifyUser?" + "userId=" + userId;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            // User user1 = JsonConvert.DeserializeObject<User>(task.Result.ToString());

        }
    }
}
