using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CometSocial.EntityFrameworkCore;
using CometSocial.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CometSocial.Web.Tests
{
    [DependsOn(
        typeof(CometSocialWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CometSocialWebTestModule : AbpModule
    {
        public CometSocialWebTestModule(CometSocialEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CometSocialWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CometSocialWebMvcModule).Assembly);
        }
    }
}