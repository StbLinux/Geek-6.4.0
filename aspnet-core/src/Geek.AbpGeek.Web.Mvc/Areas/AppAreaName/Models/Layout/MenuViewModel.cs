using Abp.Application.Navigation;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}