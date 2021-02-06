using Abp.Application.Services;
using Timesheet.MultiTenancy.Dto;

namespace Timesheet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

