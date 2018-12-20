using System.Collections.Generic;
using Geek.AbpGeek.Auditing.Dto;
using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
