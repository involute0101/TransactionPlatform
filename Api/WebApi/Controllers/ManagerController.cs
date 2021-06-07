using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerController : ControllerBase//处理用户收藏商品、查询自己收藏的商品、取消收藏、添加交易成功的记录
    {
        private readonly TranscationContext transcationContext;

        public ManagerController(TranscationContext context)
        {
            transcationContext = context;
        }

        [HttpPost("addComment")]//添加聊天记录
        public ActionResult<Comment> AddComment([FromBody] Object body)
        {
            Comment comment = JsonConvert.DeserializeObject<Comment>(body.ToString());
            try
            {
                transcationContext.Comments.Add(comment);
                transcationContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }

            return comment;
        }

        [HttpGet("getComment")]//根据商品Id查询其相关的聊天记录
        public ActionResult<Comment> GetComment(int goodId)
        {
            try
            {
                Comment comment = transcationContext.Comments.SingleOrDefault(c => c.GoodId == goodId);
                if (comment == null) return NoContent();
                else return comment;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }


        }


        //根据userId查找所有收藏商品
        [HttpGet("getCollectGoods")]
        public ActionResult<List<Good>> GetCollectByUserId(int userId)
        {
            try
            {
                var collects = transcationContext.Collects.Where(c => c.UserId == userId).ToList();//用户所有相关收藏数据
                List<Good> goods = new List<Good>();

                collects.ForEach(collect => goods.Add(transcationContext.Goods.SingleOrDefault(t => t.GoodId == collect.GoodId)));
                return goods;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        //收藏
        [HttpPost("collect")]
        public ActionResult<Collect> Collect([FromBody] Object body)
        {
            Collect c = JsonConvert.DeserializeObject<Collect>(body.ToString());
            try
            {
                transcationContext.Collects.Add(c);
                transcationContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return c;
        }

        //取消收藏
        [HttpDelete("deleteCollect")]
        public ActionResult DeleteCollect(int collectId)
        {
            try
            {
                var collect = transcationContext.Collects.FirstOrDefault(t => t.CollectId == collectId);
                if (collect != null)
                {
                    transcationContext.Remove(collect);
                    transcationContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }



        //记录交易成功的帖子
        [HttpPost("addTransactionRecord")]
        public ActionResult<TransactionRecord> AddDoneDeal([FromBody] Object body)
        {
            TransactionRecord record = JsonConvert.DeserializeObject<TransactionRecord>(body.ToString());
            try
            {
                transcationContext.TransactionRecords.Add(record);
                transcationContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return record;
        }
    }
}
