using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Workflows
{
    public interface ISensorState
    {
        int GetInt(string valueIdentifier);
        string GetString(string valueIdentifier);
        DateTimeOffset GetDateTimeOffset(string valueIdentifier);
        DateTime GetDateTime(string valueIdentifier);
        DateOnly GetDateOnly(string valueIdentifier);
        TimeOnly GetTimeOnly(string valueIdentifier);
        double GetDouble(string valueIdentifier);
        float GetFloat(string valueIdentifier);
        decimal GetDecimal(string valueIdentifier);
        bool GetBool(string valueIdentifier);

        string GetJsonUnderValue(string valueIdentifier);
    }
}
