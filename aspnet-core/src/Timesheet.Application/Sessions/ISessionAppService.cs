using System.Threading.Tasks;
using Abp.Application.Services;
using Timesheet.Sessions.Dto;

namespace Timesheet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
