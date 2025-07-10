using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CometSocial.Authorization;

namespace CometSocial
{
    [DependsOn(
        typeof(CometSocialCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CometSocialApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CometSocialAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CometSocialApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
