using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Events.Actors
{
    public class ActorCommandEvent : ActorCommandEventBase
    {
        public required ActorCommandType CommandType { get; init; }
        public string? ValueSerialized { get; init; } = null;
    }
}
