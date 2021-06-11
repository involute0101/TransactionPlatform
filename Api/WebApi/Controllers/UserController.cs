using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //使用JWT实现TOKEN认证，增加用户安全访问权限
        private readonly TranscationContext transactionContext;
        private readonly JwtOptions _jwtOptions;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;

        public UserController(TranscationContext context, JwtOptions jwtOptions,
            JwtSecurityTokenHandler jwtSecurityTokenHandler)
        {
            transactionContext = context;
            _jwtOptions = jwtOptions;
            _jwtSecurityTokenHandler = jwtSecurityTokenHandler;
        }

        [HttpGet]
        public ActionResult get()
        {
            return NoContent();
        }

        //"User/getUser"
        [HttpGet("getUser")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
        public ActionResult<string> Login(string username, string password)
        {
            var user = transactionContext.Users.FirstOrDefault(x => x.Username.Equals(username));
            if (user == null) return NotFound("用户找不到");
            if (user.Password == password)//jwt使用TOKEN
            {
                var jwtToken = new JwtSecurityToken(
                    _jwtOptions.Issuer,
                    _jwtOptions.Audience,
                    new[]
                    {
                        new Claim("USERNAME", user.Username),
                        new Claim("USERID", user.UserId.ToString())
                    },
                    null, DateTime.Now.Add(TimeSpan.FromDays(3)),
                    new SigningCredentials(_jwtOptions.SecurityKey, SecurityAlgorithms.HmacSha256));
                string jwt = _jwtSecurityTokenHandler.WriteToken(jwtToken);
                return Ok(jwt);
            }
            return BadRequest("您的密码错误！");
          
        }

        //User/modifyUser?
        [HttpPut("modifyUser")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]//添加权限设置
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
