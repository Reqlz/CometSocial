﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CometSocial.Configuration;

namespace CometSocial.Web.Host.Startup
{
    [DependsOn(
       typeof(CometSocialWebCoreModule))]
    public class CometSocialWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CometSocialWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CometSocialWebHostModule).GetAssembly());
        }
    }
}
