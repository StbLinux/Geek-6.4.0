using Abp.Notifications;
using Geek.AbpGeek.Dto;

namespace Geek.AbpGeek.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}