using System.Threading.Tasks;
using Abp.Application.Services;
using Timesheet.Authorization.Accounts.Dto;

namespace Timesheet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
