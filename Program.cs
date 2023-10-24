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
using Serilog.Events;


// Set up logger to monitor app startup
// Use Console logger because we don't have anything else yet
// CreateBootstrapLogger is Serilog's lightweight logger for app startup
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting up web host");

    var builder = WebApplication.CreateBuilder(args);

    // Exchange ASP.NET Core default logging for Serilog
    // Full setup of Serilog using the configuration in appsettings.json
    builder.Host.UseSerilog((context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext());

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<ApplicationDbContext>();
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
    builder.Services.AddScoped<TaskService>();

    var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new NullReferenceException("No connection string in configuration file.");
    builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(connectionstring));
    builder.Services.AddHttpClient();

    var app = builder.Build();

    app.UseSerilogRequestLogging(configure =>
    {
        configure.MessageTemplate = "HTTP {RequestMethod} {RequestPath} ({UserId}) responded {StatusCode} in {Elapsed:0.0000}ms";
    });

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
    app.UseRouting();
    app.UseAuthorization();
    app.MapControllers();
    app.MapBlazorHub();
    app.MapFallbackToPage("/_Host");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal("Unable to start up the app!");
    Log.Fatal(ex.Message);
    return 1;
}
finally
{
    // Write everything to the log
    Log.CloseAndFlush();
}

return 0;