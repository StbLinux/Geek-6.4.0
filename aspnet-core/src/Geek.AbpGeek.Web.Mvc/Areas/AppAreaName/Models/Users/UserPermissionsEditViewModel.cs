using Abp.AutoMapper;
using Geek.AbpGeek.Authorization.Users;
using Geek.AbpGeek.Authorization.Users.Dto;
using Geek.AbpGeek.Web.Areas.AppAreaName.Models.Common;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}