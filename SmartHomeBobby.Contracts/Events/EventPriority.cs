namespace SmartHomeBobby.Contracts.Events
{
    public enum EventPriority
    {
        // Human safty is at stake, e.g. fire alarm, gas leak, water leak, break-in
        Critical,

        // Human inconvenience is at stake, e.g. doorbell rang, motion detected, window opened
        High,

        // No immediate consequence, but still relevant, e.g. temperature update, humidity update, light level update
        Normal,

        // Informational, e.g. sensor status update, system health check, routine maintenance
        Low,
    }
}
