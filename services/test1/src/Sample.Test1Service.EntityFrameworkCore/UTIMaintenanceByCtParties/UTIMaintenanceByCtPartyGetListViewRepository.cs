using System;
using Sample.Test1Service.EntityFrameworkCore;
using Sample.Test1Service.UTIMaintenanceByCtParties;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public class UTIMaintenanceByCtPartyGetListViewRepository : EfCoreRepository<Test1ServiceDbContext, UTIMaintenanceByCtPartyGetListView, Guid>, IUTIMaintenanceByCtPartyGetListViewRepository
    {
        public UTIMaintenanceByCtPartyGetListViewRepository(IDbContextProvider<Test1ServiceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
