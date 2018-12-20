using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Geek.AbpGeek.Authorization;
using Geek.AbpGeek.Web.Controllers;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpGeekControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}