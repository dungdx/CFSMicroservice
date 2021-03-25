using Ardalis.Specification;
using CFSBusinesses.Core.EventsAggregate;
using CFSBusinesses.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CFSBusinesses.Core.Services
{
    class CFSEventServices : ICFSEventServices
    {
        public Task<CFSEvent> AddAsync(CFSEvent entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<CFSEvent> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrderAsync(CFSEvent cfsEvent)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CFSEvent entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CFSEvent> FirstAsync(ISpecification<CFSEvent> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CFSEvent> FirstOrDefaultAsync(ISpecification<CFSEvent> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CFSEvent> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CFSEvent>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CFSEvent>> ListAsync(ISpecification<CFSEvent> spec, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CFSEvent entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
