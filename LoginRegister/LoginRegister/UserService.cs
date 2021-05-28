using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoginRegister
{
    class UserService//用户访问服务器类 
    {
        public static int LoginUser(string username, string password)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/login?" +
            "userName" + username + "&&password=" + password;
            HttpClient client = new HttpClient();

            var task = client.GetStringAsync(baseUrl);
            return Convert.ToInt32(task.Result);
        }

        public static bool RegisterUser(User user_reg)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/register?";
            HttpClient client = new HttpClient();
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
            string baseUrl = "https://localhost:5001/api/hunter/user/register?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            User user_reg = new User(username,sex ,phone,password, email);
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
            string baseUrl = "https://localhost:5001/api/hunter/user/getUser?" +
                "username=" + username;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            User user = JsonConvert.DeserializeObject<User>(task.Result);
            return user;
        }

        public static User GetUser(string username,string phone)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/getUserInfoByUserId?" +
                "username=" + username +
                "phone=" + phone;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            User user = JsonConvert.DeserializeObject<User>(task.Result);
            return user;
        }

        public static void ModifyUser(int userId, User user)
        {
            string baseUrl = "https://localhost:5001/api/hunter/user/alterPersonalInfo?" + "userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            // User user1 = JsonConvert.DeserializeObject<User>(task.Result.ToString());

        }
    }
}
