using System.Threading.Tasks;
using Gas_station.Models.TokenAuth;
using Gas_station.Web.Controllers;
using Shouldly;
using Xunit;

namespace Gas_station.Web.Tests.Controllers
{
    public class HomeController_Tests: Gas_stationWebTestBase
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