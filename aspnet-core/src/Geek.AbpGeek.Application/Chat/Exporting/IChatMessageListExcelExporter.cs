using System.Collections.Generic;
using Geek.AbpGeek.Chat.Dto;
using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
