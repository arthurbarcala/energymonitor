using EnergyMonitor.Tests.Helpers;
using Xunit;

namespace EnergyMonitor.Tests
{
    public class AuthControllerTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public AuthControllerTests(
            CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Login_ReturnsStatus200()
        {
            var content = JsonContent.Create(new
            {
                usuario = "admin",
                senha = "123"
            });

            var response =
                await _client.PostAsync(
                    "/api/auth/login",
                    content);

            response.EnsureSuccessStatusCode();

            Assert.Equal(
                System.Net.HttpStatusCode.OK,
                response.StatusCode);
        }
    }
}