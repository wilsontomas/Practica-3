using ApiNoticias1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias1.Interfaces
{
   public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        //bool ValidateToken(string key, string issuer, string audience, string token);

    }
}
