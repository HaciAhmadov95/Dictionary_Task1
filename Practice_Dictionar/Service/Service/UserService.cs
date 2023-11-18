using Domain.Models;
using Service.Service.Data;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUserService
    {

        public bool Login(string email, string password)
        {
           return AppDbContext.Users().Exists(m => m.Email == email && m.Password == password);
            
        }
    }
}
