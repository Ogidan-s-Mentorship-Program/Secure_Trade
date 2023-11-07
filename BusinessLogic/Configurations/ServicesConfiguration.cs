using Microsoft.Extensions.DependencyInjection;
using SecureTrade.DataAccess.Repository.Implementation;
using SecureTrade.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
