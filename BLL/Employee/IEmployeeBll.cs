using BLL.Infrastructure;
using System.Threading.Tasks;

namespace BLL.Employee
{
    public interface IEmployeeBll
    {
        Task<RequestResponse> GetAllEmployees();
    }
}
