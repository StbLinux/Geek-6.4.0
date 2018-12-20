using System.Collections.Generic;
using Geek.AbpGeek.Authorization.Permissions.Dto;

namespace Geek.AbpGeek.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}