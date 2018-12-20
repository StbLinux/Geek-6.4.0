using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geek.AbpGeek.Authorization;

namespace Geek.AbpGeek
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(AbpGeekCoreModule)
        )]
    public class AbpGeekApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpGeekApplicationModule).GetAssembly());
        }
    }
}