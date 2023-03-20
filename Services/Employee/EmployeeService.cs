using Dto;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {

        }

        public async Task<List<EmployeeDto>> GetAllEmployees(MyContext Context)
        {
            return await Context.Database.SqlQuery<EmployeeDto>("SELECT * FROM Employees").ToListAsync();            
        }
    }
}
