using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
