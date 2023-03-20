using Dto;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Employee
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployees(MyContext Context);
    }
}
