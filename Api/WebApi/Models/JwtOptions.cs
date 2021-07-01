using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebApi.Models
{
    public class JwtOptions
    {
        //JWT加密的密钥
        public string Secret { get; set; }
        //签发人的名称
        public string Issuer { get; set; }
        //订阅人
        public string Audience { get; set; }
        
        public SecurityKey SecurityKey => new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret));
    }
}