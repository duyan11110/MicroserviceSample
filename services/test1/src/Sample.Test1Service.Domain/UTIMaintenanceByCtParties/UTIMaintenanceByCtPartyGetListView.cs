using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public class UTIMaintenanceByCtPartyGetListView : Entity<Guid>, IMultiTenant
    {
        public int CustomerID { get; set; }
        public string TransType { get; set; }
        public string Type { get; set; }
        public Guid? TenantId { get; set; }
    }
}
