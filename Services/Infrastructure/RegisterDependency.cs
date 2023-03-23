using Services.Employee;
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
