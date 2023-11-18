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
    public class EmployeeService : IEmployeeService
    {
        int IEmployeeService.GeyCountByFilter(DateTime start, DateTime end, double salary)
        {
            return AppDbContext.Employees().Where(m => m.Birthday > start && m.Birthday < end && m.Salary > salary).Count();
        }
    }
}
