using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Events.Sensors
{
    public class SensorUpdateValue : SensorEventBase
    {
        public required string SerializedNewValue { get; init; }
        public string? SerializedOldValue { get; set; } = null;
        public string? Unit { get; init; } = null; // z.B. "°C", "%"
        public double? Confidence { get; init; } = null; // Optional: Sensor‑Zuverlässigkeit (0-1)
    }
}
