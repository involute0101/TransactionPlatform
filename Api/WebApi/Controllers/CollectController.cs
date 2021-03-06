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
    public class CollectController:ControllerBase
    {
        private readonly TranscationContext transactionContext;

        public CollectController(TranscationContext context)
        {
            transactionContext = context;
        }

        /// <summary>
        /// 根据userId查找所有收藏商品
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getCollectGoods")]
        public ActionResult<List<Good>> GetCollectByUserId(int userId)
        {
            try
            {
                var collects = transactionContext.Collects.Where(c => c.UserId == userId).ToList();//用户所有相关收藏数据
                List<Good> goods = new List<Good>();
                collects.ForEach(collect => goods.Add(transactionContext.Goods.SingleOrDefault(t => t.GoodId == collect.GoodId)));
                return goods;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        /// <summary>
        /// 收藏
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost("AddCollect")]
        public ActionResult<Collect> Collect([FromBody] Object body)
        {
            Collect c = JsonConvert.DeserializeObject<Collect>(body.ToString());
            try
            {
                transactionContext.Collects.Add(c);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return c;
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="collectId"></param>
        /// <returns></returns>
        [HttpDelete("deleteCollect")]
        public ActionResult DeleteCollect(int collectId)
        {
            try
            {
                var collect = transactionContext.Collects.FirstOrDefault(t => t.CollectId == collectId);
                if (collect != null)
                {
                    transactionContext.Remove(collect);
                    transactionContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
