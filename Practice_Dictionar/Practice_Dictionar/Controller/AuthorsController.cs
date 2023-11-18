using Service.Service;
using Service.Service.Data;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dictionar.Controller
{
    internal class AuthorsController
    {
        private readonly IAuthorService _authorService;

        public AuthorsController()
        {
            _authorService = new AuthorService();
        }
        public void GetByAge()
        {

           int age = 42;

            var respons = _authorService.GetAllByAge(age);

            foreach (var item in respons)
            {
                string res = $"{item.Name} - {item.Surname}";
                Console.WriteLine(res);
            }

        }
    }
}
