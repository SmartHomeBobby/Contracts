using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Events.Sensors
{
    public class SensorEventBase : EventBase
    {
        public required string ValueIdentifier { get; init; }
        public DateTimeOffset UpdateTime { get; init; }

        public required SensorType SensorType { get; init; }

        public string? SensorTypeDescription { get; init; } = null; // Optional: For "Other" sensor type or additional description
    }
}
