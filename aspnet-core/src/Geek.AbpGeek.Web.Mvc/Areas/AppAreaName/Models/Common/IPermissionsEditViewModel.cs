using System.Collections.Generic;
using Geek.AbpGeek.Authorization.Permissions.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}