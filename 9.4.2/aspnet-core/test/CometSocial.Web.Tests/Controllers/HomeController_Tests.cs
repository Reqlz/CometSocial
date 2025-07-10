using System.Threading.Tasks;
using CometSocial.Models.TokenAuth;
using CometSocial.Web.Controllers;
using Shouldly;
using Xunit;

namespace CometSocial.Web.Tests.Controllers
{
    public class HomeController_Tests: CometSocialWebTestBase
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