using Domain.Models;

namespace Service.Service.Data
{
    public static class AppDbContext
    {
        public static List<Authors> Authors() 
       {
            return new List<Authors>()
           {
               new Authors()
               {
                   Id = 1,
                   Name = "Mark",
                   Surname = "Twen",
                   Age = 42
               },
               new Authors()
               {   Id = 2,
                   Name = "Orhan",
                   Surname = "Pamuk",
                   Age = 45
               },
               new Authors()
               {
                   Id = 3,
                   Name = "George",
                   Surname = "Orwell",
                   Age = 36
               }
           };
       }
        public static List<Employee> Employees()
        {
            return new List<Employee>()
        {
            new Employee()
            {
              Id = 1,
              Name = "Elnur",
              Surname = "Safiyev",
              Birthday = new (2000,02,02),
              Salary = 1000
            },
            new Employee()
            {
              Id = 2,
              Name = "Oruc",
              Surname = "Mehrabov",
              Birthday = new (2005,05,05),
              Salary = 2000
            },
            new Employee()
            {
              Id = 3,
              Name = "Rufat",
              Surname = "Mehrabov",
              Birthday = new (2005,05,05),
              Salary = 3000

            }




            };





        }


        public static List<User> Users() 
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "Haci@gmail.com",
                    Password = "123"
                },
                new User()
                {
                    Id=2,
                    Email = "Mermer",
                    Password = "1234"
                }
            };

        }

        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Count = 10,
                    Price = 1000,
                    Name = "Samsung"
                },
                new Product()
                {
                    Id = 2,
                    Count = 20,
                    Price = 2000,
                    Name = "Toshiba"
                }
            };
        }
    }
   
}
