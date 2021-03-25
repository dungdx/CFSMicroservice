using Ardalis.GuardClauses;
using CFSBusinesses.Core.Entities;
using CFSBusinesses.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFSBusinesses.Core.EventsAggregate
{
    public class CFSEvent: BaseEntity, IAggregate
    {
        public string AgencyCode { get; private set; }
        public string EventId { get; private set; }
        public int EventNumber { get; private set; }
        public string EventTypeCode { get; private set; }
        public DateTime EventTime { get; private set; }
        public DateTime DispatchTime { get; private set; }
        public string ResponderId { get; private set; }

        public CFSEvent(string agencyCode, string eventId, int eventNumber, 
            string eventTypeCode, DateTime eventTime, DateTime dispatchTime,string responderId)
        {
            AgencyCode = agencyCode;
            EventId = eventId;
            EventNumber = eventNumber;
            EventTypeCode = eventTypeCode;
            EventTime = eventTime;
            DispatchTime = dispatchTime;
            ResponderId = responderId;
        }
        public void UpdateDetails(DateTime eventTimeme, DateTime dispatchTime, string responderId)
        {
            Guard.Against.Null(eventTimeme, nameof(eventTimeme));
            Guard.Against.Null(dispatchTime, nameof(dispatchTime));
            Guard.Against.NullOrEmpty(responderId, nameof(responderId));

            EventTime = eventTimeme;
            DispatchTime = dispatchTime;
            ResponderId = responderId;
        }
        public void UpdateAgency(string agencyCode)
        {
            Guard.Against.NullOrEmpty(agencyCode, nameof(agencyCode));

            AgencyCode = agencyCode;
        }
        public void UpdateResponder(string responderId)
        {
            Guard.Against.NullOrEmpty(responderId, nameof(responderId));

            ResponderId = responderId;
        }
    }
}
