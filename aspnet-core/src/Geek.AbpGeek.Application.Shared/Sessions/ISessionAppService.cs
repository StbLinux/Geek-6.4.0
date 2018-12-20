using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.Sessions.Dto;

namespace Geek.AbpGeek.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
