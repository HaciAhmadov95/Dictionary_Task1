using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Dictionar.Controller
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetCountByFilter()
        {
            double salary = 2000;
            DateTime start = new(1990,01,01);
            DateTime end = new(2020, 01, 01);

            var res = _employeeService.GeyCountByFilter(start,end,salary);
            Console.WriteLine(res);
        }
    }
}
