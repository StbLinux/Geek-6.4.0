using System.Threading.Tasks;
using Abp.Application.Services;

namespace Geek.AbpGeek.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
