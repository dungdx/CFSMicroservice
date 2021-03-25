using Ardalis.Specification;
using CFSBusinesses.Core.EventsAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFSBusinesses.Core.Specifications
{
    public class CFSEventsFilterSpecification: Specification<CFSEvent>
    {
        public CFSEventsFilterSpecification(string agency_code, string responder)
        {
            Query.Where(e => e.AgencyCode == agency_code && e.ResponderId == responder);
        }
    }
}
