// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public partial class UTIMaintenanceByCtParty : Entity<Guid>, IMultiTenant
    {
        public int CustomerID { get; set; }
        public string TransType { get; set; }
        public string Type { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Guid? CancelApprovedBy { get; set; }
        public DateTime? CancelApprovedDate { get; set; }
        public Guid? TenantId { get; set; }
    }
}