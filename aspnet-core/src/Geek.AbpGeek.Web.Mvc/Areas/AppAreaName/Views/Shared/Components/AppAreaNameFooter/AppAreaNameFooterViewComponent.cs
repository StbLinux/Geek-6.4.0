using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Geek.AbpGeek.Web.Areas.AppAreaName.Models.Layout;
using Geek.AbpGeek.Web.Session;
using Geek.AbpGeek.Web.Views;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : AbpGeekViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
