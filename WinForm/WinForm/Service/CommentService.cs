using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForm.Entity;
using WinForm.Util;

namespace WinForm.Service
{
    public static class CommentService
    {
        private static String serverAddress = "http://localhost:5001/"; //服务器地址

        private static HttpClient client = new HttpClient();

        //添加聊天记录
        public static bool AddComment(Comment comment)
        {
            string baseUrl = serverAddress + "Comment/addComment?";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(comment),
                Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }

        //查询与商品和用户本人有关的聊天记录
        public static List<Comment> GetComment(int goodId,int userId)
        {
            string baseUrl = serverAddress + "Comment/getComment?goodId=" +goodId + "&userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(task.Result);
            return comments;
        }

        //查询与本人有关的聊天消息
        public static List<Message> GetMessage(int userId)
        {
            string baseUrl = serverAddress + "Comment/getMessage?userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Message> messages = JsonConvert.DeserializeObject<List<Message>>(task.Result);

            return messages;
        }
    }
}
