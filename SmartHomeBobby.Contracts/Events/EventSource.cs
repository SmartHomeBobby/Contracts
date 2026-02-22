namespace SmartHomeBobby.Contracts.Events
{
    public class EventSource
    {
        public required string Module { get; init; } // z.B. "sensor-lr", "llm-agent", "alarm"
        public required string Host { get; init; } // z.B. "unraid-01", "mac-mini"
        public required string Version { get; init; } // Modulversion
    }
}
