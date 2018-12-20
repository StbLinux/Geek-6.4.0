using System.Collections.Generic;
using Geek.AbpGeek.Authorization.Users.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}