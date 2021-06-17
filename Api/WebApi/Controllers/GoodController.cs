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
        private readonly TranscationContext transactionContext;

        public GoodController(TranscationContext context)
        {
            transactionContext = context;
        }

        // "/Good"
        [HttpGet]
        public ActionResult<List<Good>> GetAllGoods()
        {
            return transactionContext.Goods.ToList();
        }

        //按goodId查询
        [HttpGet("getGoodById")]
        public ActionResult<Good> GetGoodByGoodId(int goodId)
        {
            Good good;
            try 
            { 
                good = transactionContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            if (good == null)
                return NotFound();
            else
                return good;
        }

        //按goodName查询
        [HttpGet("getGoodByName")]
        public ActionResult<List<Good>> GetGoodByGoodName(string goodName)
        {
            var goods = transactionContext.Goods.Where(t => t.GoodName == goodName);
            if (goods == null)
                return NotFound();
            else
                return goods.ToList();
        }

        ////根据用户Id查询商品
        [HttpGet("getGoodByUserId")]
        public ActionResult<List<Good>> GetGoodByUserID(int userId)
        {
            var goods = transactionContext.Goods.Where(t => t.SellerId == userId);
            if (goods == null)
                return NotFound();
            else
                return goods.ToList();
        }

        //"/Good/addGood"添加商品
        [HttpPost("addGood")]
        public ActionResult<String> AddPost(Good good)
        {
            try 
            {
                transactionContext.Goods.Add(good);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return "success";
        }

        //删除商品（商家权限，关于商品全部删除）
        [HttpDelete("deletePost")]
        public ActionResult DeletePost(int userId, int goodId)
        {
            try
            {
                var comments = transactionContext.Comments.Where(t => t.GoodId == goodId);
                transactionContext.Comments.RemoveRange(comments);

                //删除用户收集项
                var collects = transactionContext.Collects.Where(t => t.GoodId == goodId);
                transactionContext.Collects.RemoveRange(collects);

                //删除商品
                Good good = transactionContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
                transactionContext.Goods.Remove(good);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        //修改商品
        [HttpPut("alterPost")]
        public ActionResult<Good> AlterPost(int goodId, Good good)
        {
            var goods = transactionContext.Goods.Where(t => t.GoodId == goodId);
            if (goods == null)
            {
                return NotFound();
            }
            Good entity = goods.ToList()[0] as Good;
            if (entity == null)return entity;

            entity.GoodDetailDesc = good.GoodDetailDesc;
            entity.GoodName = good.GoodName;
            entity.Count = good.Count;
            entity.Price = good.Price;
            entity.State = good.State;
            try
            {
                transactionContext.Goods.Update(entity);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return entity;
        }
    }
}
