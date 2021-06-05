using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Mdl.HostedConsoleApplication
{
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// Build and run the specified <see cref="IHostedConsoleApplication" /> implementation.
        /// </summary>
        /// <param name="builder">The host builder.</param>
        /// <typeparam name="T">An implementation of <see cref="IHostedConsoleApplication" />.</typeparam>
        public static async Task RunConsoleApplicationAsync<T>(this IHostBuilder builder) where T : class, IHostedConsoleApplication
        {
            builder.ConfigureServices((_, services) => services.AddSingleton<IHostedConsoleApplication, T>());
            
            using var serviceScope = builder.Build().Services.CreateScope();
            
            var application = serviceScope.ServiceProvider.GetRequiredService<IHostedConsoleApplication>();
            await application.RunAsync();
        }
    }
}