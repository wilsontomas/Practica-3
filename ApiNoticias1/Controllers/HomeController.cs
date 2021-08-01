using ApiNoticias1.Interfaces;
using ApiNoticias1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;

        public HomeController(IConfiguration config, ITokenService tokenService, IUserRepository userRepository)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }


        [Authorize]
        [HttpPost("Login")]
        public string Login(UserDTO model)
        {
            return _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), model);
           
        }
    }
}
