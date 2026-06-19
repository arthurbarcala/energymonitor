using EnergyMonitor.Tests.Helpers;
using Xunit;

namespace EnergyMonitor.Tests
{
    public class AlertasControllerTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public AlertasControllerTests(
            CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAlertas_ReturnsStatus200()
        {
            var response =
                await _client.GetAsync("/api/alertas");

            response.EnsureSuccessStatusCode();

            Assert.Equal(
                System.Net.HttpStatusCode.OK,
                response.StatusCode);
        }
    }
}