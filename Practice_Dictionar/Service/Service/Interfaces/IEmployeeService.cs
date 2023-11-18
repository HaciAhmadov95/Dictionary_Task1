using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IEmployeeService
    {
        int  GeyCountByFilter(DateTime start,DateTime end,double salary);
    }
}
