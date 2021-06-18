using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi
{
    public static class Extensions
    {
        public static async Task<User> GetCurrentUser(this HttpContext httpContext, DbSet<User> users)
        {
            var username = httpContext.User.FindFirst("Username")?.Value;
            return await users.FirstAsync(x => x.Username.Equals(username));
        }
    }
}
