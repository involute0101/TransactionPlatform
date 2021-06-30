using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using WinForm.EntityClass;
using WinForm.Tool;

namespace WinForm.Service
{
    class TransactionService
    {
        private static String serverAddress = "http://localhost:5001/"; //服务器地址
        //根据id查询买家购买的商品
        public static HttpClient client;
        public static List<Good> GetAllRecordsById(int id)
        {
            string baseUrl = serverAddress + "TransactionRecord/getTransactionRecordByBuyer?" +
                "buyerId=" + id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            //得到买家所有买的商品
            List<Good> goods = JsonConvert.DeserializeObject<List<Good>>(task.Result);
            foreach (var g in goods)
            {
                MemoryStream ms = new MemoryStream(g.ImageByte);

                g.Image = ImageTool.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();
            }
            return goods;
        }
        //根据id查询交易记录
        public static List<TransactionRecord> GetAllRecordsByBuyerId(int id)
        {
            string baseUrl = serverAddress + "TransactionRecord/getTransactionRecordByBuyerId?" +
                "buyerId=" + id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<TransactionRecord> records = JsonConvert.DeserializeObject<List<TransactionRecord>>(task.Result);

            return records;
        }

        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static bool AddRecord(TransactionRecord record)
        {
            string baseUrl = serverAddress + "TransactionRecord/addTransactionRecord?";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content1 = new StringContent(JsonConvert.SerializeObject(record),
                Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content1);
            task.Wait();
            if (task.Result == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 根据id查询交易记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TransactionRecord GetTransactionRecordById(int id)
        {
            string baseUrl = serverAddress + "TransactionRecord/getTransactionById?tranId="+id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            TransactionRecord record = JsonConvert.DeserializeObject<TransactionRecord>(task.Result);
            return record;
        }
    }
}
