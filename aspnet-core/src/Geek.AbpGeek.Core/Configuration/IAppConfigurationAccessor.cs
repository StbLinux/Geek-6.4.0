using Microsoft.Extensions.Configuration;

namespace Geek.AbpGeek.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
