using System;
using Sample.Test1Service.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public class UTIMaintenanceByCtPartyRepository : EfCoreRepository<Test1ServiceDbContext, UTIMaintenanceByCtParty, Guid>, IUTIMaintenanceByCtPartyRepository
    {
        public UTIMaintenanceByCtPartyRepository(IDbContextProvider<Test1ServiceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
