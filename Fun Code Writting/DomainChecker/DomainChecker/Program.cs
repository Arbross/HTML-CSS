using DomainChecker.Classes;
using DomainChecker.Helpers;
using DomainChecker.Interfaces;
using DomainChecker.Services;
using Serilog.Events;
using Serilog.Formatting.Json;
using Serilog;

namespace DomainChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(new JsonFormatter(),
                    "Logs/important-logs.json",
                    restrictedToMinimumLevel: LogEventLevel.Warning)
                .WriteTo.File("Logs/all-daily-.logs",
                    rollingInterval: RollingInterval.Day)
                .ReadFrom.Configuration(configuration)
                .MinimumLevel.Debug()
                .CreateLogger();

            try
            {
                Log.Information("Application starting up.");

                IHost host = Host.CreateDefaultBuilder(args)
                    .UseSerilog()
                    .ConfigureServices(services =>
                    {
                        services.AddHostedService<Worker>();
                        services.AddScoped<ICheckLinkService, CheckLinkService>();
                        services.AddScoped<IProductServiceManager, ProductServiceManager>();
                        services.AddScoped<IProxyProvider, FileProxyProvider>();
                    })
                   .Build();

                host.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The application failed to start correctly.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}