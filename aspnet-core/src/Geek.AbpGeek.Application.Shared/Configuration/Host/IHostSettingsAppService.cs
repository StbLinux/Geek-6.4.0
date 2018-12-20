using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.Configuration.Host.Dto;

namespace Geek.AbpGeek.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
