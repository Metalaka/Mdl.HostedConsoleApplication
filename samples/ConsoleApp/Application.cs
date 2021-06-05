using System;
using System.Threading;
using System.Threading.Tasks;
using Mdl.HostedConsoleApplication;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    public class Application : IHostedConsoleApplication
    {
        private readonly ILogger<Application> _logger;

        public Application(ILogger<Application> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Hello World!");
                
            // wait for the logger worker to write the message
            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
        }
    }
}