using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Geek.AbpGeek
{
    [DependsOn(typeof(AbpGeekXamarinSharedModule))]
    public class AbpGeekXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpGeekXamarinAndroidModule).GetAssembly());
        }
    }
}