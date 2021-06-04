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

        //按postId查询帖子
        [HttpGet("getGoodById")]
        public ActionResult<Good> GetGoodByGoodId(int goodId)
        {
            var good = transcationContext.Goods.SingleOrDefault(t => t.GoodId == goodId);
            if (good != null)
                return good;
            else
                return NotFound();
        }

        //"/Good/addGood"
        [HttpPost("addGood")]
        public ActionResult<String> AddPost(Good good)
        {
            transcationContext.Goods.Add(good);
            transcationContext.SaveChanges();
            return "success";
        }
    }
}
