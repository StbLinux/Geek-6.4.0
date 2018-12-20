using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Geek.AbpGeek.Web.Controllers
{
    public class HomeController : AbpGeekControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
