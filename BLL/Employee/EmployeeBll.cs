using BLL.Infrastructure;
using Entities.Context;
using Services.Employee;
using System.Threading.Tasks;

namespace BLL.Employee
{
    public class EmployeeBll : BllMaster, IEmployeeBll
    {
        private readonly IEmployeeService _IEmployeeService;
        public EmployeeBll(IEmployeeService _IEmployeeService, MyContext Context) : base(Context)
        {
            this._IEmployeeService = _IEmployeeService;
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
