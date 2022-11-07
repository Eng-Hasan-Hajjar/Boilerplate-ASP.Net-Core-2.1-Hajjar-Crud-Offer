using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplateasp.Authorization;

namespace boilerplateasp
{
    [DependsOn(
        typeof(boilerplateaspCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class boilerplateaspApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<boilerplateaspAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(boilerplateaspApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
