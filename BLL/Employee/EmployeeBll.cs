using BLL.Infrastructure;
using Dto;
using Entities.Context;
using Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Employee
{
    public class EmployeeBll : BllMaster, IEmployeeBll
    {        
        private readonly IEmployeeService _IEmployeeService;
        public EmployeeBll(
            IEmployeeService _IEmployeeService,
            MyContext Context
            )
        {
            this._IEmployeeService = _IEmployeeService;
            this.Context = Context;
        }

        public async Task<RequestResponse> GetAllEmployees()
        {
            return await SendResponse(async () =>
            {
                return await _IEmployeeService.GetAllEmployees(Context);
            });
        }
    }
}
