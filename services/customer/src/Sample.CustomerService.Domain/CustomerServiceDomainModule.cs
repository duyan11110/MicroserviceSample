using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Sample.CustomerService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CustomerServiceDomainSharedModule)
)]
public class CustomerServiceDomainModule : AbpModule
{

}
