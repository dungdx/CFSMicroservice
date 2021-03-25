using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class CreateCFSEventResponse : BaseResponse
    {
        public CreateCFSEventResponse(Guid correlationId) : base(correlationId)
        {
        }

        public CreateCFSEventResponse()
        {
        }

        public CFSEventDto CFSEvent { get; set; }
    }
}

