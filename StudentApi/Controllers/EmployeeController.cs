using BLL.Employee;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmployeeApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeBll _IEmployeeBll;
        public EmployeeController(IEmployeeBll _IEmployeeBll)
        {
            this._IEmployeeBll = _IEmployeeBll;
        }

        [HttpGet]
        [Route("api/employees")]
        public async Task<IHttpActionResult> GetAllEmployees()
        {
            return Ok(await _IEmployeeBll.GetAllEmployees());
        }
    }
}
