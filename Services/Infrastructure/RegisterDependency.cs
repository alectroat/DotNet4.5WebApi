using Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Services.Infrastructure
{
    public static class RegisterDependency
    {
        public static void RegisterServiceDependency(this UnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
        }
    }
}
