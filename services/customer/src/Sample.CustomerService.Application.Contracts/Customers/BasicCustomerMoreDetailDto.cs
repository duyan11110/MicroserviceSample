using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Sample.CustomerService.Customers
{
    public class BasicCustomerMoreDetailDto : EntityDto
    {
        public int CustomerID { get; set; }
        public string CustomerAbbr { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string CurrencyCode { get; set; }
    }
}
