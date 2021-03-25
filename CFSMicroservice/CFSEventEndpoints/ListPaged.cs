using Ardalis.ApiEndpoints;
using AutoMapper;
using CFSBusinesses.Core.EventsAggregate;
using CFSBusinesses.Core.Interfaces.IServices;
using CFSBusinesses.Core.Specifications;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class ListPaged : BaseAsyncEndpoint
        .WithRequest<ListPagedCFSEventRequest>
        .WithResponse<ListPagedCFSEventResponse>
    {
        private readonly IAsyncRepository<CFSEvent> _cfsEventRepository;
        private readonly IMapper _mapper;
        public ListPaged(IAsyncRepository<CFSEvent> cfsEventRepository,
            IMapper mapper)
        {
            _cfsEventRepository = cfsEventRepository;
            _mapper = mapper;
        }
        [HttpPost("api/cfs-events")]
        [SwaggerOperation(
           Summary = "Creates a new event",
           Description = "Creates a new event",
           OperationId = "cfs-events.create",
           Tags = new[] { "CFSEventEndpoints" })
       ]
        public override async Task<ActionResult<ListPagedCFSEventResponse>> HandleAsync([FromQuery] ListPagedCFSEventRequest request, CancellationToken cancellationToken)
        {
            var response = new ListPagedCFSEventResponse(request.CorrelationId());

            var filterSpec = new CFSEventsFilterPaginatedSpecification(
                skip: request.PageIndex * request.PageSize,
                take: request.PageSize,
                request.AgencyCode,
                request.FromDate,
                request.ToDate);

            int totalItems = await _cfsEventRepository.CountAsync(filterSpec, cancellationToken);

            var items = await _cfsEventRepository.ListAsync(filterSpec, cancellationToken);

            response.Events.AddRange(items.Select(_mapper.Map<CFSEventDto>));            
            response.PageCount = int.Parse(Math.Ceiling((decimal)totalItems / request.PageSize).ToString());

            return Ok(response);
        }
    }
}
