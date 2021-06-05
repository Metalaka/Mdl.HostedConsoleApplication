# HostedConsoleApplication

This is a simple extension method to build console applications the same way we build web apps.

# How to use

Bellow there is a basic example.
More samples can be found under the dedicated folder. 

```c#
using Mdl.HostedConsoleApplication;

namespace Examples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            // configurations goes here

            await builder.RunConsoleApplicationAsync<Application>();
        }
    }
    
    public class Application : IHostedConsoleApplication
    {
        public async Task RunAsync(CancellationToken cancellationToken)
        {
            // inject your dependecies and code your best console app :) 
        }
    }
}
```
