using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwaggerAndBearer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = "Secure Trade",
                        Version = "v1",
                        Description = "Secure Trade allows you to make trade on different products securely"
                    });

                    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        Description = "Secure Trade JWT Authorization header using the Bearer scheme",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                    });

                    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer",
                                },
                            },
                            new string[] { }
                        },
                    });
            });
        }
    }
}
