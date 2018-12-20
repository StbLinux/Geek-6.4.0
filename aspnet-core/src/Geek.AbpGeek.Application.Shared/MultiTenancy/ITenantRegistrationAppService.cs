using System.Threading.Tasks;
using Abp.Application.Services;
using Geek.AbpGeek.Editions.Dto;
using Geek.AbpGeek.MultiTenancy.Dto;

namespace Geek.AbpGeek.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}