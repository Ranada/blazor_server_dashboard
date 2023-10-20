using blazor_server_dashboard.Areas.Identity;
using blazor_server_dashboard.Data;
using blazor_server_dashboard.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

try
{
    //var configuration = new ConfigurationBuilder()
    //    .AddJsonFile("appsettings.json")
    //    .Build();

    //Console.WriteLine("CONFIGURATION: {0}", configuration.ToString());

    //Log.Logger = new LoggerConfiguration()
    //    .ReadFrom.Configuration(configuration)
    //    .CreateLogger();

    Log.Logger = new LoggerConfiguration()
        .WriteTo.Console()
        .CreateLogger();

    Log.Information("Starting up with Serilog!");
}
catch (Exception ex)
{
    Console.WriteLine("SOMETHING WEIRD HAPPENED WITH THE LOGGING CONFIG...");
    Console.WriteLine(ex.ToString());
}

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddScoped<TaskService>();


//try
//{
//    Log.Information("Application start up!");
//}
//catch (Exception ex)
//{
//    Log.Fatal(ex, "The application failed to start correctly.");
//}
//finally
//{
//    //Cleans up logs still pending by writing them before closing
//    Log.CloseAndFlush();
//}

var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new NullReferenceException("No connection string in configuration file.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(connectionstring));
builder.Services.AddHttpClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

//app.UseSerilogRequestLogging();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
