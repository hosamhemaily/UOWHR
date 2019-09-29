using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthenticationController(IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GenerateToken([FromBody] LogInModel model)
        {
            var result=await _userManager.FindByEmailAsync(model.UserName);
            if (ModelState.IsValid && result!=null)
            {
                {
                    {                       
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, result.UserName),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, result.Email)
                        };
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:TOKEN_KEY"]));
                        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            _configuration["Tokens:Issuer"],
                            _configuration["Tokens:Audience"],
                            claims,
                            expires: DateTime.Now.AddMinutes(20),
                            signingCredentials: credentials
                            );
                        LoggedInUser.Id = new Guid();
                        LoggedInUser.FullName = $"{"hosam"} {"hemaily"}";
                        LoggedInUser.Token = new JwtSecurityTokenHandler().WriteToken(token);
                        LoggedInUser.Expiry = token.ValidTo;

                        //var response =  LoggedInUser
                        //{
                        //    Id = new Guid(),
                        //    FullName = $"{"hosam"} {"hemaily"}",
                        //    Token = new JwtSecurityTokenHandler().WriteToken(token),
                        //    Expiry = token.ValidTo
                        //};

                        return Created("", new {
                            LoggedInUser.Id,
                            LoggedInUser.FullName,
                            LoggedInUser.Token,
                            LoggedInUser.Expiry
                        });
                    }
                }
            }

            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Generateuser([FromBody] LogInModel model)
        {
            var result= await _userManager.CreateAsync(new ApplicationUser
            {
                Id = new Guid(),
                UserName="hosamyahiataha",
                Email="hosam.h@contecdigital.co.uk"
                
                
            },"Admin@123");

            return Ok(result);
        }
    }
}