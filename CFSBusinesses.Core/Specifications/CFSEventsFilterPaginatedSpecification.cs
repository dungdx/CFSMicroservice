using Ardalis.Specification;
using CFSBusinesses.Core.EventsAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFSBusinesses.Core.Specifications
{
    public class CFSEventsFilterPaginatedSpecification : Specification<CFSEvent>
    {
        public CFSEventsFilterPaginatedSpecification(int skip, int take, string agency_code, DateTime frmDate, DateTime toDate)
            : base()
        {
            Query
                .Where(e => e.AgencyCode == agency_code && (DateTime.Compare(frmDate, e.EventTime) <= 0 && DateTime.Compare(toDate, e.EventTime) >= 0))
                .Paginate(skip, take);
        }
    }
}
