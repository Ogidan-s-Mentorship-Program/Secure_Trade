using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SecureTrade.DataAccess.Context
{
    public class MyAppContext: DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options): base(options)
    {
        
    }
        
    }
}