using Microsoft.AspNetCore.Mvc;
using Geek.AbpGeek.Web.Controllers;

namespace Geek.AbpGeek.Web.Public.Controllers
{
    public class AboutController : AbpGeekControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}