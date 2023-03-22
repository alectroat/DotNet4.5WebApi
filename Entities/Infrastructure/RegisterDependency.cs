using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Entities.Infrastructure
{
    public static class RegisterDependency
    {
        public static void RegisterDbContext(this UnityContainer container)
        {
            container.RegisterType<MyContext>();
        }
    }
}
