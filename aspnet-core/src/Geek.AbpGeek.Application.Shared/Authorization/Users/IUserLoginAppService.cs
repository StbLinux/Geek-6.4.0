using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Authorization.Users.Dto;

namespace Geek.AbpGeek.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
