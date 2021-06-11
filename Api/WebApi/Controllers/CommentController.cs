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
    public class CommentController : ControllerBase//交易聊天记录
    {
        private readonly TranscationContext transactionContext;

        public CommentController(TranscationContext context)
        {
            transactionContext = context;
        }

        [HttpPost("addComment")]//添加聊天记录
        public ActionResult<Comment> AddComment([FromBody] Object body)
        {
            Comment comment = JsonConvert.DeserializeObject<Comment>(body.ToString());
            try
            {
                transactionContext.Comments.Add(comment);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return comment;
        }

        [HttpGet("getComment")]//根据商品Id查询其相关的聊天记录
        public ActionResult<Comment> GetComment(int goodId)
        {
            try
            {
                Comment comment = transactionContext.Comments.SingleOrDefault(c => c.GoodId == goodId);
                if (comment == null) return NoContent();
                else return comment;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }


        }

       
    }
}
