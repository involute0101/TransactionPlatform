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
    public class GoodController : ControllerBase
    {
        private readonly TranscationContext transcationContext;

        public GoodController(TranscationContext context)
        {
            transcationContext = context;
        }

        // "/Good"
        [HttpGet]
        public ActionResult<List<Good>> GetAllGoods()
        {
            return transcationContext.Goods.ToList();
        }

        //按postId查询
        [HttpGet("getGoodById")]
        public ActionResult<Good> GetGoodByGoodId(int goodId)
        {
            var good = transcationContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
            if (good != null)
                return good;
            else
                return NotFound();
        }

        //按postName查询
        [HttpGet("getGoodByName")]
        public ActionResult<List<Good>> GetGoodByGoodName(string goodName)
        {
            var goods = transcationContext.Goods.Where(t => t.GoodName == goodName);
            if (goods != null)
                return goods.ToList();
            else
                return NotFound();
        }

        ////根据用户名查询商品
        [HttpGet("getGoodByUsername")]
        public ActionResult<List<Good>> GetGoodByUsername(string username)
        {
            User user = transcationContext.Users.SingleOrDefault(t => t.Username == username);
            var goods = transcationContext.Goods.Where(t => t.UserId == user.UserId);
            if (goods != null)
                return goods.ToList();
            else
                return NotFound();
        }

        //"/Good/addGood"添加商品
        [HttpPost("addGood")]
        public ActionResult<String> AddPost(Good good)
        {
            transcationContext.Goods.Add(good);
            transcationContext.SaveChanges();
            return "success";
        }

        //删除商品（商家权限，关于商品全部删除）
        [HttpDelete("deletePost")]
        public ActionResult DeletePost(int userId, int goodId)
        {
            
            var comments = transcationContext.Comments.Where(t => t.GoodId == goodId);
            transcationContext.Comments.RemoveRange(comments);

            //删除用户收集项
            var collects = transcationContext.Collects.Where(t => t.GoodId == goodId);
            transcationContext.Collects.RemoveRange(collects);

            //删除帖子
            Good good = transcationContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
            transcationContext.Goods.Remove(good);
            transcationContext.SaveChanges();
            return NoContent();
        }

        //修改商品
        [HttpPut("alterPost")]
        public ActionResult<Good> AlterPost(int goodId, Good good)
        {
            var goods = transcationContext.Goods.Where(t => t.GoodId == goodId);
            if (goods == null)
            {
                return NotFound();
            }
            Good entity = goods.ToList()[0] as Good;
            if (entity == null)
            {
                return entity;
            }

            entity.GoodDetailDesc = good.GoodDetailDesc;
            
            entity.GoodName = good.GoodName;
            entity.Price = good.Price;
            entity.State = good.State;
            transcationContext.Goods.Update(entity);
            transcationContext.SaveChanges();
            return entity;
        }
    }
}
