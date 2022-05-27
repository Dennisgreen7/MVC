using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET_CORE_MVC.Models;

namespace ASPNET_CORE_MVC.Data
{
    public class ASPNET_CORE_MVCContext : DbContext
    {
        public ASPNET_CORE_MVCContext (DbContextOptions<ASPNET_CORE_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET_CORE_MVC.Models.Recipe> Recipe { get; set; }
    }
}
