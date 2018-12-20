using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Geek.AbpGeek.Web.Areas.AppAreaName.Models.Layout;
using Geek.AbpGeek.Web.Session;
using Geek.AbpGeek.Web.Views;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameDefaultBrand
{
    public class AppAreaNameDefaultBrandViewComponent : AbpGeekViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameDefaultBrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
