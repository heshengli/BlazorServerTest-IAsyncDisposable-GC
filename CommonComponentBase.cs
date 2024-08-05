using Microsoft.AspNetCore.Components;

namespace BlazorServerTest
{
    public class CommonComponentBase : OwningComponentBase, IAsyncDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public async ValueTask DisposeAsync()
        {
            if (ScopedServices != null)
            {
                await ((IAsyncDisposable)this.ScopedServices).DisposeAsync();
            }
            Dispose();
            await Task.CompletedTask;
        }
    }
}
