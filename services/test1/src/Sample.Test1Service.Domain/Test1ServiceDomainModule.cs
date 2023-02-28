using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Sample.Test1Service;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(Test1ServiceDomainSharedModule)
)]
public class Test1ServiceDomainModule : AbpModule
{

}
