using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Sample.CustomerService;

[DependsOn(
    typeof(CustomerServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CustomerServiceApplicationContractsModule : AbpModule
{

}
