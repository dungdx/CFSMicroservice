using CFSBusinesses.Core.EventsAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CFSBusinesses.Core.Interfaces.IServices
{
    public interface ICFSEventServices: IAsyncRepository<CFSEvent>
    {
        Task CreateOrderAsync(CFSEvent cfsEvent);

    }
}
