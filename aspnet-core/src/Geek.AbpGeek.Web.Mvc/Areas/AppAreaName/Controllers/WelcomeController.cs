using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Geek.AbpGeek.Web.Controllers;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : AbpGeekControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}