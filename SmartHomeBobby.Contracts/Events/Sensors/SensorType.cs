namespace SmartHomeBobby.Contracts.Events.Sensors
{
    public enum SensorType
    {
        Temperature,
        Motion,
        Contact,
        Humidity,
        AirQuality,
        Light,
        Sound,
        Other, // For future sensor types or custom sensors, with an additional "SensorTypeDescription" property if needed
    }
}
