using Abp.AutoMapper;
using Geek.AbpGeek.Organizations.Dto;

namespace Geek.AbpGeek.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}