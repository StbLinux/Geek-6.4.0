using System.Collections.Generic;
using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}