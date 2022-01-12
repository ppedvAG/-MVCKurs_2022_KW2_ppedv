#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HollywoodMovieApp.Models;

namespace HollywoodMovieApp.Data
{
    public class HollywoodDbContext : DbContext
    {
        public HollywoodDbContext (DbContextOptions<HollywoodDbContext> options)
            : base(options)
        {
        }
        //DbSet ist eine Tabelle in Objekt Orientierter Form 
        public DbSet<HollywoodMovieApp.Models.Actor> Actor { get; set; }

        public DbSet<HollywoodMovieApp.Models.Reggiseur> Reggiseur { get; set; }

        public DbSet<HollywoodMovieApp.Models.Movie> Movie { get; set; }
    }
}
