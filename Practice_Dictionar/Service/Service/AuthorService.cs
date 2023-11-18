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
    public class AuthorService : IAuthorService
    {
        public List<Authors> GetAllByAge(int age)
        {
            return AppDbContext.Authors().Where(m => m.Age == age).ToList();
        }
    }
}
