using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SecureTrade.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public static class DbConfiguration
    {
        public static void AddDbConfig(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<MyAppContext>(options =>
            //{
            //    options.UseSqlServer(configuration.GetConnectionString(name: "DefaultConnection"));
            //});

            services.AddDbContext<MyAppContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
