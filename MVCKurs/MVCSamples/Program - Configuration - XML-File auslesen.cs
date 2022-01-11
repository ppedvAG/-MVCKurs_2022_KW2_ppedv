//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//    config.Sources.Clear(); //Lösche alle Konfigurations Quellen 

//    IHostEnvironment env = hostingContext.HostingEnvironment;

//    config.AddXmlFile("MyXMLFile.xml", optional: true, reloadOnChange: true)
//          .AddXmlFile($"MyXMLFile.{env.EnvironmentName}.xml",
//                         optional: true, reloadOnChange: true);

//    config.AddEnvironmentVariables();

//    if (args != null)
//    {
//        config.AddCommandLine(args);
//    }
//});

////Optional -> 
//builder.Services.Configure<PositionOptions>(
//    builder.Configuration.GetSection(PositionOptions.Position));



//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
