using System.Threading.Tasks;
using Timesheet.Models.TokenAuth;
using Timesheet.Web.Controllers;
using Shouldly;
using Xunit;

namespace Timesheet.Web.Tests.Controllers
{
    public class HomeController_Tests: TimesheetWebTestBase
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