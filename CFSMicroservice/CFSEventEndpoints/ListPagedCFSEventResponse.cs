using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class ListPagedCFSEventResponse:BaseResponse
    {
        public ListPagedCFSEventResponse(Guid correlationId) : base(correlationId)
        {
        }

        public ListPagedCFSEventResponse()
        {
        }

        public List<CFSEventDto> Events { get; set; } = new List<CFSEventDto>();
        public int PageCount { get; set; }
    }
}
