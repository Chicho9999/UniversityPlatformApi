using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UniversityPlatformApi.Data.Models;
using UniversityPlatformApi.Service.Interfaces;
using UniversityPlatformApi.ViewModels;

namespace UniversityPlatformApi.Service
{
    public class AuthService : IAuthService
    {
        string jwtSecret;
        int jwtLifespan;

        public AuthService(string jwtSecret, int jwtLifespan)
        {
            this.jwtSecret = jwtSecret;
            this.jwtLifespan = jwtLifespan;
        }
        public AuthData GetAuthDataAsync(int id)
        {
            var expirationTime = DateTime.UtcNow.AddSeconds(jwtLifespan);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, id.ToString()),

                }),
                Expires = expirationTime,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret)),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

            return new AuthData
            {
                Token = token,
                TokenExpirationTime = ((DateTimeOffset)expirationTime).ToUnixTimeSeconds(),
                Id = id
            };
        }

        public string HashPassword(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();

            return passwordHasher.HashPassword(user, password);
        }

        public bool VerifyPassword(User user,string actualPassword, string hashedPassword)
        {
            var passwordHasher = new PasswordHasher<User>();
            var verifiedPassword = passwordHasher.VerifyHashedPassword(user, hashedPassword, actualPassword);

            return verifiedPassword.ToString() == "Success";
        }
    }
}
