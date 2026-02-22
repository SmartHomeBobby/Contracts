using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Events
{
    public abstract class EventBase
    {
        public required Guid TraceId { get; init; }
        public required Guid EventId { get; init; } = Guid.NewGuid();

        public required DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;

        public required EventSource Sender { get; init; } // z.B. "sensor-lr", "llm-agent", "alarm"

        public required EventPriority Priority { get; set; }
    }
}
