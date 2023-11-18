using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dictionar.Controller
{
    internal class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }
        public void GetAll()
        {
            var result = _productService.GetAll();  
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }
        }

        public void Search()
        {
            Console.WriteLine("Add search text");
            string searchText = Console.ReadLine();

            var resp = _productService.Search(searchText);
            foreach (var item in resp)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
