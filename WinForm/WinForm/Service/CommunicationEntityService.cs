using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WinForm.EntityClass;
using WinForm.Tool;

namespace WinForm.Service
{
    class CommunicationEntityService
    {
        private string ServerAddress = "http://localhost:5001/";

        //向服务器发送身份认证，告诉服务器自己的Userid和ipStringPort
        public bool sendIdentify(String ipStringPort, String UserId, String GoalUserId)
        {
            string baseUrl = ServerAddress + "Server/identify?";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            CommunicationEntity communication = new CommunicationEntity(ipStringPort, UserId, GoalUserId);
            HttpContent content = new StringContent(JsonConvert.SerializeObject(communication), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();

            if (Convert.ToString(task.Result).Equals("success")) return true;
            else return false;
        }

        //告诉服务器发送的信息类型
        public String SendInfoType(String infoType)
        {
            string baseUrl = ServerAddress + "Server/infoType?infoType=" + infoType;
            HttpClient client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return StaticVar.INFOTYPE = infoType;
        }
    }
}
