using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice.CFSEventEndpoints
{
    public class ListPagedCFSEventRequest:BaseRequest
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string AgencyCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
