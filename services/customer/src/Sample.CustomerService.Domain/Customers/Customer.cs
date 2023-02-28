using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Sample.CustomerService.Customers
{
    public class Customer : Entity
    {
        public int CustomerID { get; set; }
        public string CustomerAbbr { get; set; }
        public string CustomerName { get; set; }
        public int CompanyID { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string LicenseNumber { get; set; }
        public string PassportNo { get; set; }
        public override object[] GetKeys()
        {
            return new object[] { CustomerID };
        }
    }
}
