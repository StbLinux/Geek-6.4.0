using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Authorization.Permissions.Dto;

namespace Geek.AbpGeek.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
