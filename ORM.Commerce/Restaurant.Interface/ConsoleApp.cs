using MediatR;
using Microsoft.Extensions.Hosting;
using Restaurant.Service.EventHandlers.Commands;
using Restaurant.Service.Queries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.Interface
{
    public class ConsoleApp : IHostedService
    {
        private readonly IComandaQueryService _comandaQueryService;
        private readonly IMediator _mediator;
        public ConsoleApp(IComandaQueryService comandaQueryService)
        {
            _comandaQueryService = comandaQueryService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Extract receipts");
                Console.WriteLine("2. Upload receipts");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye...");
                        break;
                    case 1:
                     
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
