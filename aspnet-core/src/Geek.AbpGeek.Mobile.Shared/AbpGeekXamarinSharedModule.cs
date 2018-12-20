using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Geek.AbpGeek
{
    [DependsOn(typeof(AbpGeekClientModule), typeof(AbpAutoMapperModule))]
    public class AbpGeekXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpGeekXamarinSharedModule).GetAssembly());
        }
    }
}