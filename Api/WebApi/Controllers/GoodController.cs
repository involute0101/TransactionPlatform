using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        /// <summary>
        /// 得到所有商品
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Good>> GetAllGoods()
        {
            return transactionContext.Goods.ToList();
        }

        /// <summary>
        /// 按goodId查询
        /// </summary>
        /// <param name="goodId"></param>
        /// <returns></returns>
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
            if (good == null)return NotFound();
            return good;
        }

        /// <summary>
        /// 按goodName查询
        /// </summary>
        /// <param name="goodName"></param>
        /// <returns></returns>
        [HttpGet("getGoodByName")]
        public ActionResult<List<Good>> GetGoodByGoodName(string goodName)
        {
            var goods = transactionContext.Goods.Where(t => t.GoodName == goodName);
            if (goods == null)return NotFound();
            return goods.ToList();
        }

        /// <summary>
        /// 根据用户Id查询商品
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getGoodByUserId")]
        public ActionResult<List<Good>> GetGoodByUserID(int userId)
        {
            var goods = transactionContext.Goods.Where(t => t.SellerId == userId);
            if (goods == null)return NotFound();
            return goods.ToList();
        }

        /// <summary>
        /// "/Good/addGood"添加商品
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        [HttpPost("addGood")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//添加权限设置
        public async Task<ActionResult<string>> AddGoodAsync(Good good)
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

        /// <summary>
        /// 删除商品（商家权限，关于商品全部删除）
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="goodId"></param>
        /// <returns></returns>
        [HttpDelete("deleteGood")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//添加权限设置
        public async Task<ActionResult> DeleteGoodAsync(int userId, int goodId)
        {
            try
            {
                var user = await HttpContext.GetCurrentUser(transactionContext.Users);
                
                Good good = transactionContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
                if (user.UserId != userId && good.SellerId!=userId) return BadRequest();//确保操作者是商品所有者

                var comments = transactionContext.Comments.Where(t => t.GoodId == goodId);
                transactionContext.Comments.RemoveRange(comments);

                //删除用户收集项
                var collects = transactionContext.Collects.Where(t => t.GoodId == goodId);
                transactionContext.Collects.RemoveRange(collects);

                //删除商品
                
                transactionContext.Goods.Remove(good);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        /// <summary>
        /// 修改商品所有属性（卖家）
        /// </summary>
        /// <param name="goodId"></param>
        /// <param name="good"></param>
        /// <returns></returns>
        [HttpPut("alterGood")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//添加权限设置
        public async Task<ActionResult<Good>> AlterGoodAsync(int goodId, Good good)
        {
            var user = await HttpContext.GetCurrentUser(transactionContext.Users);
            var goods = transactionContext.Goods.Where(t => t.GoodId == goodId);

            if (goods == null)return NotFound();

            Good entity = goods.ToList()[0] as Good;
            if (entity == null)return entity;
            if(entity.SellerId!=user.UserId) return BadRequest();//确保操作者是商品所有者

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

        /// <summary>
        /// 修改商品数量和状态
        /// </summary>
        /// <param name="goodId"></param>
        /// <param name="good"></param>
        /// <returns></returns>
        [HttpPut("alterGoodByBuyer")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//添加权限设置
        public async Task<ActionResult<Good>> AlterGoodByBuyerAsync(int goodId, Good good)
        {
            var goods = transactionContext.Goods.Where(t => t.GoodId == goodId);
            if (goods == null) return NotFound();
            Good entity = goods.ToList()[0] as Good;
            if (entity == null) return entity; 
            
            entity.Count = good.Count;
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
