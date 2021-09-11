using System.Threading.Tasks;
using Xunit;

namespace Application.IntegrationTests
{
    using static Testing;

    public class TestBase : IClassFixture<Testing>, IAsyncLifetime
    {
        public async Task InitializeAsync()
        {
            await ResetState();
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}