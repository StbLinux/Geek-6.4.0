using Abp.AspNetCore.Mvc.ViewComponents;

namespace Geek.AbpGeek.Web.Public.Views
{
    public abstract class AbpGeekViewComponent : AbpViewComponent
    {
        protected AbpGeekViewComponent()
        {
            LocalizationSourceName = AbpGeekConsts.LocalizationSourceName;
        }
    }
}