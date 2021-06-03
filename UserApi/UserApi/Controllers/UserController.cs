using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserApi.Models;
using System.Collections.Generic;
using LoginRegister;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserContext userDB;

        public UserController(UserContext context)
        {
            userDB = context;
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
                var user_temp = userDB.Users.FirstOrDefault(t => t.Username == username);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
        //"User/forget"
        [HttpGet("forget")]
        public ActionResult<User> Forget(String username,String email,String phone)
        {
            try
            {
                var user_temp = userDB.Users.FirstOrDefault(t => t.Username == username&&t.Email==email&&t.PhoneNumber==phone);
                return user_temp;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }


        //注册
        //访问路径：/User/register?
        [HttpPost("register")]
        public ActionResult<User> Register(User user)
        {
            try
            {
                //查询用户名，邮箱是否重复
                var user_temp1 = userDB.Users.FirstOrDefault(t => t.Username == user.Username);
                var user_temp2 = userDB.Users.FirstOrDefault(t => t.Email == user.Email);
                if (user_temp1 == null && user_temp2 == null)
                {
                    userDB.Users.Add(user);
                    userDB.SaveChanges();
                    return user;
                }
                else
                    return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        
        //访问路径：/User/login?
        //通过用户名登录
        [HttpGet("login")]
        public ActionResult<int> Login(String username, String password)
        {
            var user_temp = userDB.Users.FirstOrDefault(u => u.Username == username);
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

        //修改个人中心显示出来的个人信息
        //访问路径：/User/modifyUser?
        [HttpPut("modifyUser")]
        public ActionResult<User> ModifyUser(int userId, User user)
        {
            if (userId != user.UserId)
            {
                return BadRequest("Id cannot be modified!");
            }
            else
            {
                userDB.Entry(user).State = EntityState.Modified;
                userDB.SaveChanges();
            }
            return user;
        }


        

    }
}
