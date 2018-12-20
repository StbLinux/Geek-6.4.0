using System.Threading.Tasks;

namespace Geek.AbpGeek.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
