using Guide.Service.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Guide.Service.Services
{
    public class UserService : IUserService
    {
        public (string username, string token)? Authenticate(string username, string password)
        {

            var user = new BL.User { Token = "", Id = "1", Username = "admin", Password = "admin" };

            if (user == null || username != user.Username || user.Password != password) //To Do: statik yapı, dinamik yapıya çevrilebilir.
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("secretKey123456789");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //Özel olarak şu Claimler olsun dersek buraya ekleyebiliriz.
                Subject = new ClaimsIdentity(new[]
                {
                    //İstersek string bir property istersek ClaimsTypes sınıfının sabitlerinden çağırabiliriz.
                    new Claim("userId", user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.Username)
                }),
                //Tokenın hangi tarihe kadar geçerli olacağını ayarlıyoruz.
                Expires = DateTime.UtcNow.AddMinutes(2),
                //Son olarak imza için gerekli algoritma ve gizli anahtar bilgisini belirliyoruz.
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            //Token oluşturuyoruz.
            var token = tokenHandler.CreateToken(tokenDescriptor);
            //Oluşturduğumuz tokenı string olarak bir değişkene atıyoruz.
            string generatedToken = tokenHandler.WriteToken(token);

            user.Token = "Bearer " + generatedToken;

            //Sonuçlarımızı tuple olarak dönüyoruz.
            return (user.Username, generatedToken);
        }
    }
}
