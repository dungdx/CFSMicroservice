using Ardalis.ApiEndpoints;
using CFSBusinesses.Core.EventsAggregate;
using CFSBusinesses.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class Create : BaseAsyncEndpoint
        .WithRequest<CreateCFSEventRequest>
        .WithResponse<CreateCFSEventResponse>
    {
        private readonly IAsyncRepository<CFSEvent> _cfsEventRepository;
        public Create(IAsyncRepository<CFSEvent> cfsEventRepository)
        {
            _cfsEventRepository = cfsEventRepository;          
        }
        [HttpPost("api/cfs-events")]
        [SwaggerOperation(
           Summary = "Creates a new event",
           Description = "Creates a new event",
           OperationId = "cfs-events.create",
           Tags = new[] { "CFSEventEndpoints" })
       ]
        public override async Task<ActionResult<CreateCFSEventResponse>> HandleAsync(CreateCFSEventRequest request, CancellationToken cancellationToken = default)
        {
            var response = new CreateCFSEventResponse(request.CorrelationId());

            var newCFSEvent = new CFSEvent(request.AgencyCode, request.EventId, request.EventNumber, request.EventTypeCode, request.EventTime, request.DispatchTime,request.ResponderId);

            newCFSEvent = await _cfsEventRepository.AddAsync(newCFSEvent, cancellationToken);

            if (newCFSEvent.Id != 0)
            {
                await _cfsEventRepository.UpdateAsync(newCFSEvent, cancellationToken);
            }

            var dto = new CFSEventDto
            {
                Id = newCFSEvent.Id,
                AgencyCode = newCFSEvent.AgencyCode,
                EventId = newCFSEvent.EventId,
                EventNumber = newCFSEvent.EventNumber,
                EventTypeCode = newCFSEvent.EventTypeCode,
                EventTime = newCFSEvent.EventTime,
                DispatchTime = newCFSEvent.DispatchTime,
                ResponderId = newCFSEvent.ResponderId
            };
            response.CFSEvent = dto;
            return response;
        }
    }
}
