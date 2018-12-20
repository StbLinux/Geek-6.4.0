using System.Threading.Tasks;
using Geek.AbpGeek.Security.Recaptcha;

namespace Geek.AbpGeek.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
