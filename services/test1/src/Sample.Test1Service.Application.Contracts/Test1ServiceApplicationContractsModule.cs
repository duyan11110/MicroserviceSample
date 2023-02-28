using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Sample.Test1Service;

[DependsOn(
    typeof(Test1ServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class Test1ServiceApplicationContractsModule : AbpModule
{

}
