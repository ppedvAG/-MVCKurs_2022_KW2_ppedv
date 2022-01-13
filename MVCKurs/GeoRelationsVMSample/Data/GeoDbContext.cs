#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeoRelationsVMSample.Models;

namespace GeoRelationsVMSample.Data
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext (DbContextOptions<GeoDbContext> options)
            : base(options)
        {
        }

        public DbSet<GeoRelationsVMSample.Models.Continent> Continents { get; set; }

        public DbSet<GeoRelationsVMSample.Models.Language> Languages { get; set; }
        public DbSet<GeoRelationsVMSample.Models.Country> Countries { get; set; }
        public DbSet<GeoRelationsVMSample.Models.LanguageInCountry> LanguageCountry { get; set; }
    }
}
