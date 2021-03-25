using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFSMicroservice
{
    public abstract class BaseMessage
    {
        /// <summary>
        /// Unique Identifier used by logging
        /// </summary>
        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}
