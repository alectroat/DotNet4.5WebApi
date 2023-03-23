using BLL.Employee;
using Entities.Infrastructure;
using Services.Infrastructure;
using Unity;

namespace BLL.Infrastructure
{
    public static class RegisterDependency
    {
        public static void RegisterBllDependency(this UnityContainer container)
        {
            container.RegisterType<IEmployeeBll, EmployeeBll>();
            container.RegisterDbContext();
            container.RegisterServiceDependency();            
        }
    }
}
