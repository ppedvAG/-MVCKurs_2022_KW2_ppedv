using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DefaultWebAPI.Models;

namespace DefaultWebAPI.Data
{
    public class DefaultWebAPIContext : DbContext
    {
        public DefaultWebAPIContext (DbContextOptions<DefaultWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DefaultWebAPI.Models.Employee> Employee { get; set; }

        public DbSet<DefaultWebAPI.Models.Movie> Movie { get; set; }
    }
}
