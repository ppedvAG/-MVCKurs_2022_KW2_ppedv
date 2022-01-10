using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5_DefaultProject
{
    public class Program
    {
        //Programm - Einstiegspunkt 
        public static void Main(string[] args)
        {
            //Punkt 1 - Main Methode
            CreateHostBuilder(args).Build().Run(); //Schritt 4 Build + Schritt 5 Run
        }


        //Punkt 2 - 
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args) 
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); //Punkt 3 -  gehe ins Startup
                });
    }
}
