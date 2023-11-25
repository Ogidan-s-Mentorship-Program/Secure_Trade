using Microsoft.AspNetCore.Identity;
using SecureTrade.DataAccess.Context;
using SecureTrade.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Seed
{
    public class Seeder
    {
        public async static Task Seed(RoleManager<IdentityRole> roleManager, UserManager<Admin> userManager, MyAppContext dbContext)
        {
            await dbContext.Database.EnsureCreatedAsync();
            await SeedRoles(roleManager, dbContext);
        }
        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager, MyAppContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                var roles = SeederHelper<string>.GetData("Roles.json");
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }
        }
   
    
    }
}
