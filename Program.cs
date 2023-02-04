using ConsoleAppWithDI;
using ConsoleAppWithDI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<ICustomerService, CustomerService>();
            services.AddSingleton<App>();
        })
        .ConfigureAppConfiguration(app =>
        {
            app.AddJsonFile("appsettings.json");
        });
}