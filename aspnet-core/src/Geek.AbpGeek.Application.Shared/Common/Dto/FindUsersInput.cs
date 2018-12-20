using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}