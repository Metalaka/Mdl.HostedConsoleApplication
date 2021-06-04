using System.Threading;
using System.Threading.Tasks;

namespace Mdl.HostedConsoleApplication
{
    public interface IHostedConsoleApplication
    {
        async Task RunAsync() => await RunAsync(CancellationToken.None);
        Task RunAsync(CancellationToken cancellationToken);
    }
}