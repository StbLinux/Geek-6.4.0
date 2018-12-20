using System.Collections.Generic;
using Geek.AbpGeek.Authorization.Users.Dto;
using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}