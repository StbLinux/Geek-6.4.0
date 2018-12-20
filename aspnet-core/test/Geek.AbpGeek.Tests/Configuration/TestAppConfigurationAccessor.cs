using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Geek.AbpGeek.Configuration;

namespace Geek.AbpGeek.Tests.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(AbpGeekTestModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
