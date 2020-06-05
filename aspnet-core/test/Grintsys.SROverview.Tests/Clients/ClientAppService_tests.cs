using Grintsys.SROverview.Clients;
using Grintsys.SROverview.Clients.Dto;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Grintsys.SROverview.Tests.Clients
{
    public class ClientAppService_tests : SROverviewTestBase
    {
        private readonly IClientAppService _clientAppService;

        public ClientAppService_tests()
        {
            _clientAppService = Resolve<IClientAppService>();
        }

        [Fact]
        public async Task GetClient_Test()
        {
            // Act
            // Create record Manually
            var newClient = new Client
            {
                Name = "Sergio Peralta",
                Email = "serpel.js@gmail.com",
                Code = "AAA132",
                Celphone = "99989292",
                Phone = "1231312",
                Sexo = Sexo.Masculino,
            };

            await UsingDbContextAsync(async context =>
            {
                context.Client.Add(newClient);
                await context.SaveChangesAsync();
            });

            var input = new GetClientInput
            {
                Id = 1
            };

            //Arrage
            var output = await _clientAppService.GetClient(input);

            // Assert
            output.ShouldNotBeNull();
        }

        [Fact]
        public async Task CreateClient_ShouldCreateNewClientTest()
        {
            // Act        
            var input = new ClientDto
            {
                Name = "Gerson Caballero",
                Code = "A12345",
                IdNumber = "217377237"
            };

            //Arrage
            var output = await _clientAppService.CreateAsync(input);

            // Assert
            output.ShouldNotBeNull();
            output.IdNumber.ShouldBe(input.IdNumber);
            output.Name.ShouldBe(input.Name);
            output.Code.ShouldBe(input.Code);
        }
    }
}
