using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.CustomerService.Customers
{
    public class CustomerAppService : CustomerServiceAppService, ICustomerAppService
    {
        ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //public async Task<LoadResult> GetBasicListAsync(int skip, int take)
        //{
        //    DataSourceLoadOptions loadOptions = new DataSourceLoadOptions();
        //    loadOptions.Skip = skip;
        //    loadOptions.Take = take;
        //    int companyId = 1;
        //    var customers = await _customerRepository.GetQueryableAsync();
        //    var query = (from c in customers
        //                 where c.CompanyID == companyId
        //                select new
        //                {
        //                    c.CustomerID,
        //                    c.CustomerAbbr,
        //                    c.CustomerName,
        //                    c.Address
        //                });

        //    return await DataSourceLoader.LoadAsync(query, loadOptions);
        //}

        public async Task<LoadResult> GetBasicListAsync(DataSourceLoadOptions loadOptions)
        {
            int companyId = 1;
            var customers = await _customerRepository.GetQueryableAsync();
            var query = (from c in customers
                         where c.CompanyID == companyId
                         select new
                         {
                             c.CustomerID,
                             c.CustomerAbbr,
                             c.CustomerName,
                             c.Address
                         });

            return await DataSourceLoader.LoadAsync(query, loadOptions);
        }

        public async Task<BasicCustomerDto> GetByIdAsync(int customerID)
        {          
            var customers = await _customerRepository.GetQueryableAsync();
            var query = (from c in customers
                         where c.CustomerID == customerID
                         select new BasicCustomerDto()
                         {
                             CustomerID = c.CustomerID,
                             CustomerAbbr = c.CustomerAbbr,
                             CustomerName = c.CustomerName,
                             Address = c.Address                             
                         });


            return query.FirstOrDefault();
        }
    }
}
