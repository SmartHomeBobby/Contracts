using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHomeBobby.Contracts.Events.Actors
{
    public abstract class ActorCommandEventBase : EventBase
    {
        public required string ValueIdentifier { get; init; }
    }
}
