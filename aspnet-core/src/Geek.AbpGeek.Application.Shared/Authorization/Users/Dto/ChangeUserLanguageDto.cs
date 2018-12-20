using System.ComponentModel.DataAnnotations;

namespace Geek.AbpGeek.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
