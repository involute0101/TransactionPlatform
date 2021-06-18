using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Tool;

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
        public ActionResult<List<Comment>> GetComment(int goodId,int userId)
        {
            try
            {
                List<Comment> comments = transactionContext.Comments.
                    Where(c => c.GoodId == goodId && (c.SenderId == userId || c.ReceiverId == userId)).ToList();
                if (comments == null) return NoContent();
                else return comments;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //查询用户的聊天消息
        [HttpGet("getMessage")]
        public ActionResult<List<Message>> GetMessage(int userId)
        {
            try
            {
                List<Message> messages = new List<Message>();
                var results = transactionContext.Comments.
                    Where(c => c.ReceiverId == userId).Select(c => new { c.GoodId, c.SenderId, c.Time }).Distinct().ToList();
                foreach(var r in results)
                {
                    Message m = new Message(r.GoodId, r.SenderId, r.Time);
                    messages.Add(m);
                }
                if (messages == null) return NoContent();
                else return messages;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

    }
}
