using System.Threading.Tasks;
using Timesheet.Configuration.Dto;

namespace Timesheet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
