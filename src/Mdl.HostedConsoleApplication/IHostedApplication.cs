using System.Threading;
using System.Threading.Tasks;

namespace Mdl.HostedConsoleApplication
{
    /// <summary>
    /// Describe a console application entry point.
    /// </summary>
    public interface IHostedConsoleApplication
    {
        async Task RunAsync() => await RunAsync(CancellationToken.None);
        Task RunAsync(CancellationToken cancellationToken);
    }
}