using System.ComponentModel.DataAnnotations;

namespace Geek.AbpGeek.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}