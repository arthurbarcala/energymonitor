using EnergyMonitor.Tests.Helpers;
using Xunit;

namespace EnergyMonitor.Tests
{
    public class SetoresControllerTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public SetoresControllerTests(
            CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetSetores_ReturnsStatus200()
        {
            var response =
                await _client.GetAsync("/api/setores");

            response.EnsureSuccessStatusCode();

            Assert.Equal(
                System.Net.HttpStatusCode.OK,
                response.StatusCode);
        }
    }
}