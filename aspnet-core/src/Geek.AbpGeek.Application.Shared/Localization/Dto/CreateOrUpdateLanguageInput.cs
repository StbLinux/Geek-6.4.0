using System.ComponentModel.DataAnnotations;

namespace Geek.AbpGeek.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}