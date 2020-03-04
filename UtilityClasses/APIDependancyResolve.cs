using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity;
using WebAPI_All_Sesions.Contracts;
using WebAPI_All_Sesions.Models;

namespace WebAPI_All_Sesions.UtilityClasses
{
    public class APIDependancyResolve : IDependencyResolver
    {
        UnityContainer unity;

        public APIDependancyResolve()
        {
            unity = new UnityContainer();
            unity.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return unity.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return unity.ResolveAll(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}