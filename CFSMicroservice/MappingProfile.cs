using AutoMapper;
using CFSBusinesses.Core.EventsAggregate;
using CFSMicroservice.CFSEventEndpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CFSEvent, CFSEventDto>();          
        }
    }
}
