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
    public class UserController : ControllerBase
    {
        private readonly TranscationContext transactionContext;

        public UserController(TranscationContext context)
        {
            transactionContext = context;
        }

        [HttpGet]
        public ActionResult get()
        {
            return NoContent();
        }

        //"User/getUser"
        [HttpGet("getUser")]
        public ActionResult<User> GetUser(String username)
        {
            try
            {
                var user_temp = transactionContext.Users.FirstOrDefault(t => t.Username == username);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //"User/forget"
        [HttpGet("forget")]
        public ActionResult<User> Forget(String username, String email, String phone)
        {
            try
            {
                var user_temp = transactionContext.Users.FirstOrDefault(t => t.Username == username && t.Email == email && t.PhoneNumber == phone);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //注册
        //User/register
        [HttpPost("register")]
        public ActionResult<User> Register(User user)
        {
            try
            {
                //查询用户名，邮箱是否重复
                var user_temp1 = transactionContext.Users.FirstOrDefault(t => t.Username == user.Username);
                var user_temp2 = transactionContext.Users.FirstOrDefault(t => t.Email == user.Email);
                if (user_temp1 == null && user_temp2 == null)
                {
                    transactionContext.Users.Add(user);
                    transactionContext.SaveChanges();
                    return user;
                }
                else
                    return NotFound("该用户已存在!");
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }


        //User/login?
        [HttpGet("login")]
        public ActionResult<int> Login(String username, String password)
        {
            var user_temp = transactionContext.Users.FirstOrDefault(u => u.Username == username);
            if (user_temp == null)
            {
                return 0;
            }
            else if (user_temp.Password == password)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        //User/modifyUser?
        [HttpPut("modifyUser")]
        public ActionResult<User> ModifyUser(int userId, User user)
        {
            if (userId != user.UserId)
            {
                return BadRequest("Id cannot be modified!");
            }
            else
            {
                transactionContext.Entry(user).State = EntityState.Modified;
                transactionContext.SaveChanges();
            }
            return user;
        }


    }
}
