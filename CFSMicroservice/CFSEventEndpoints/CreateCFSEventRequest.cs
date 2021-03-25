using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class CreateCFSEventRequest: BaseRequest
    {
        public string AgencyCode { get; set; }
        public string EventId { get; set; }
        public int EventNumber { get; set; }
        public string EventTypeCode { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime DispatchTime { get; set; }
        public string ResponderId { get; set; }
    }
}
