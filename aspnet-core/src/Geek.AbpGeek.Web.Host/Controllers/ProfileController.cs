using Abp.AspNetCore.Mvc.Authorization;
using Geek.AbpGeek.Storage;

namespace Geek.AbpGeek.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}