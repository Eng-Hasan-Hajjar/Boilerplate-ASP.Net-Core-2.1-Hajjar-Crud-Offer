using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplateasp.Configuration;

namespace boilerplateasp.Web.Host.Startup
{
    [DependsOn(
       typeof(boilerplateaspWebCoreModule))]
    public class boilerplateaspWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boilerplateaspWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplateaspWebHostModule).GetAssembly());
        }
    }
}
