using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Roles
{
    public class RoleListViewModel
    {
        public List<ComboboxItemDto> Permissions { get; set; }
    }
}