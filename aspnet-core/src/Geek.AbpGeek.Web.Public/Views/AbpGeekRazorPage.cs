using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Geek.AbpGeek.Web.Public.Views
{
    public abstract class AbpGeekRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpGeekRazorPage()
        {
            LocalizationSourceName = AbpGeekConsts.LocalizationSourceName;
        }
    }
}
