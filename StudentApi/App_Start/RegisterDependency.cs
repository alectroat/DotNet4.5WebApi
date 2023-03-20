using BLL.Employee;
using BLL.Infrastructure;
using EmployeeApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;

namespace EmployeeApi.App_Start
{
    public class RegisterDependency
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IEmployeeBll, EmployeeBll>();
            container.RegisterChildDependency();
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}