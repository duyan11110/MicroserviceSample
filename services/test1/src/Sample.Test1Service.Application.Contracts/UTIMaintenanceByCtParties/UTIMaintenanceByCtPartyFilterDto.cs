using System;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public class UTIMaintenanceByCtPartyFilterDto
    {
        public DateTime? InputDateFrom { get; set; }
        public DateTime? InputDateTo { get; set; }
        public string RefNo { get; set; }
        public string TransType { get; set; }
        public string Type { get; set; }
        public Guid? StatusId { get; set; }
        public int? CustomerID { get; set; }
        public string StatusCode { get; set; }
    }
}
