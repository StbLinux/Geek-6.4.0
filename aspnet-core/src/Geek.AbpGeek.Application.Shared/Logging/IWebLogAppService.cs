using Abp.Application.Services;
using Geek.AbpGeek.Dto;
using Geek.AbpGeek.Logging.Dto;

namespace Geek.AbpGeek.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
