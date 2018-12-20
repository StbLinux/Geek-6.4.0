using Abp.AutoMapper;
using Geek.AbpGeek.Authorization.Roles.Dto;
using Geek.AbpGeek.Web.Areas.AppAreaName.Models.Common;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}