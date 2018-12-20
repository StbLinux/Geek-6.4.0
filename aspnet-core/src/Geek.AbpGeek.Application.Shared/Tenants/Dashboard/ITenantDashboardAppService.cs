using Abp.Application.Services;
using Geek.AbpGeek.Tenants.Dashboard.Dto;

namespace Geek.AbpGeek.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();

        GetDashboardDataOutput GetDashboardData(GetDashboardDataInput input);

        GetSalesSummaryOutput GetSalesSummary(GetSalesSummaryInput input);

        GetRegionalStatsOutput GetRegionalStats(GetRegionalStatsInput input);

        GetGeneralStatsOutput GetGeneralStats(GetGeneralStatsInput input);
    }
}
