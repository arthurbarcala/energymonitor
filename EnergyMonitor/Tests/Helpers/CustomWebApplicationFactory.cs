using Microsoft.AspNetCore.Mvc.Testing;

namespace EnergyMonitor.Tests.Helpers
{
    public class CustomWebApplicationFactory<TProgram>
        : WebApplicationFactory<TProgram>
        where TProgram : class
    {
    }
}