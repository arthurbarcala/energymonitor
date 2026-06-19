using EnergyMonitor.Tests.Helpers;
using Xunit;

namespace EnergyMonitor.Tests
{
    public class EquipamentosControllerTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public EquipamentosControllerTests(
            CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetEquipamentos_ReturnsStatus200()
        {
            var response =
                await _client.GetAsync("/api/equipamentos");

            response.EnsureSuccessStatusCode();

            Assert.Equal(
                System.Net.HttpStatusCode.OK,
                response.StatusCode);
        }
    }
}