using System;
using Volo.Abp.Application.Dtos;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public class UTIMaintenanceByCtPartyDto : EntityDto<Guid>
    {
        public int CustomerID { get; set; }
        public string CustomerAbbr { get; set; }
        public string CustomerName { get; set; }
        public string TransType { get; set; }
        public string Type { get; set; }
        public Guid? StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? InputDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ApprovedBy { get; set; }
        public string ApprovedByName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Guid? CancelApprovedBy { get; set; }
        public string CancelApprovedByName { get; set; }
        public DateTime? CancelApprovedDate { get; set; }
        public Guid? TenantId { get; set; }
    }
}
