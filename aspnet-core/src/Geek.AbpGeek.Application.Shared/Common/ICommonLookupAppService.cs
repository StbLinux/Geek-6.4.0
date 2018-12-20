using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Common.Dto;
using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}