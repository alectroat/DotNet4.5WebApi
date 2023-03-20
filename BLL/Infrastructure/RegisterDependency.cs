using Entities.Context;
using Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace BLL.Infrastructure
{
    public static class RegisterDependency
    {
        public static void RegisterChildDependency(this UnityContainer container)
        {
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<MyContext>();
        }
    }
}
