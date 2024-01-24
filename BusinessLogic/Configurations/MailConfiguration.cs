using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SecureTrade.Services.MailServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public static class MailConfiguration
    {
        public static void ConfigureMailing(this IServiceCollection services, IConfiguration configuration)
        {
            var emailConfig = configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
        }
    }
}
