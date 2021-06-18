﻿using Newtonsoft.Json;
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
            foreach (var g in goods)
            {
                MemoryStream ms = new MemoryStream(g.ImageByte);

                g.Image = ImageTool.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();
            }
            return goods;
        }

        //根据商品ID查询商品
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

        //根据用户ID查询商品
        public static List<Good> GetGoodByUserId(int userId)
        {
            string baseUrl = serverAddress + "Good/getGoodByUserId?" +
                "userId=" + userId;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            List<Good> goods = JsonConvert.DeserializeObject<List<Good>>(task.Result);
            foreach (var g in goods)
            {
                MemoryStream ms = new MemoryStream(g.ImageByte);

                g.Image = ImageTool.ResizeImage(new Bitmap(ms), new Size(200, 200));
                ms.Close();
            }
            return goods;
        }

        //发布商品
        public static bool AddGood(Good good)
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

        //修改商品(卖家)
        public static void AlterGood(int goodId, Good good)
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
        //修改商品(买家)
        public static void AlterGoodByBuyer(int goodId, Good good)
        {
            string baseUrl = serverAddress + "Good/alterPostByBuyer?" + "GoodId=" + goodId;
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

