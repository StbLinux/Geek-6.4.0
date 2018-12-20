using System.Threading.Tasks;

namespace Geek.AbpGeek.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}