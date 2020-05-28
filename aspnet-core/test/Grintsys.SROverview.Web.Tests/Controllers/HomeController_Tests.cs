using System.Threading.Tasks;
using Grintsys.SROverview.Models.TokenAuth;
using Grintsys.SROverview.Web.Controllers;
using Shouldly;
using Xunit;

namespace Grintsys.SROverview.Web.Tests.Controllers
{
    public class HomeController_Tests: SROverviewWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}