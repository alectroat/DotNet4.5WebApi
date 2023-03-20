using BLL.Infrastructure;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Employee
{
    public interface IEmployeeBll
    {
        Task<RequestResponse> GetAllEmployees();
    }
}
