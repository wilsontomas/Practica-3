using ApiNoticias1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias1.Interfaces
{
   public interface IUserRepository
    {
        UserDTO GetUser(UserModel userMode);
    }
}
