using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.Install.Dto;

namespace Geek.AbpGeek.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}