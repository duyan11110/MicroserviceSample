using System;
using Volo.Abp.Domain.Repositories;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public interface IUTIMaintenanceByCtPartyRepository : IRepository<UTIMaintenanceByCtParty, Guid>
    {
    }
}
