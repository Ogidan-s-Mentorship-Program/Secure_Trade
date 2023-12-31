﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SecureTrade.DataAccess.Context;
using SecureTrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public static class IdentityConfiguration
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(x =>
            {
                x.Password.RequireUppercase = true;
                x.Password.RequiredLength = 7;
                x.Password.RequireDigit = true;
                x.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<MyAppContext>()
                .AddDefaultTokenProviders();
            

        }
    }
}
