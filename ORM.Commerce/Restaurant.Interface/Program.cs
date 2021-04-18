using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Persistence.Database;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Restaurant.Interface
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);

            await hostBuilder.RunConsoleAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostingContext, services) =>
           {

               services.AddMediatR(Assembly.Load("Restaurant.Service.EventHandlers"));

               services.AddSingleton<IHostedService, ConsoleApp>();
           });
    }
}

