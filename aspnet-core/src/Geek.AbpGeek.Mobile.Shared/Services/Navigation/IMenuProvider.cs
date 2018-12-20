using System.Collections.Generic;
using MvvmHelpers;
using Geek.AbpGeek.Models.NavigationMenu;

namespace Geek.AbpGeek.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}