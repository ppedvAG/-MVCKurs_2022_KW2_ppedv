using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeoRelationsSample.Models;

namespace GeoRelationsSample.Data
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext (DbContextOptions<GeoDbContext> options)
            : base(options)
        {
        }

        //Diese Tabellen haben keinen FK und werden zuerst ersteööt
        public DbSet<GeoRelationsSample.Models.Continent> Continents { get; set; }
        public DbSet<GeoRelationsSample.Models.Language> Languages { get; set; }
        public DbSet<GeoRelationsSample.Models.Country> Countries { get; set; }
        public DbSet<GeoRelationsSample.Models.LanguageInCountry> LanguageCountry { get; set; }
    }
}
