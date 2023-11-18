using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dictionar.Controller
{
    internal class UserController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }


        public bool Login()
        {
             Console.WriteLine("Add your email: ");
             Email: string email = Console.ReadLine();

            Console.WriteLine("Add your password: ");
            string password = Console.ReadLine();

            bool response = _userService.Login(email, password);


            if(!response)
            {
                Console.WriteLine("Email or password wrong,Please enter input again");
                goto Email;
            }
            return true;
            
        }
    }
}
