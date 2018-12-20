using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Geek.AbpGeek
{
    [DependsOn(typeof(AbpGeekXamarinSharedModule))]
    public class AbpGeekXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpGeekXamarinIosModule).GetAssembly());
        }
    }
}