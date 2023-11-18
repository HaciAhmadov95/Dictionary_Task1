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
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();


    
            
        }

        public List<Product> Search(string searchText)
        {
            return AppDbContext.Products().Where(m => m.Name.Contains(searchText)).ToList();
        }
    }
}
