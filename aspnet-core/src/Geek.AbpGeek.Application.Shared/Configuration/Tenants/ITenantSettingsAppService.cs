using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.Configuration.Tenants.Dto;

namespace Geek.AbpGeek.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
