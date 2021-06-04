using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult<Comment> AddComment(Comment comment)//往数据库中添加聊天记录表；根据用户收藏表查询用户收藏商品
        {
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

        [HttpPost("getComment")]//根据商品Id查询其相关的聊天记录
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
        public ActionResult<Collect> Collect(Collect c)
        {
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
        [HttpPost("addDoneDeal")]
        public ActionResult<DoneDeal> AddDoneDeal(DoneDeal dd)
        {
            try
            {
                transcationContext.DoneDeals.Add(dd);
                transcationContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return dd;
        }
    }
}
