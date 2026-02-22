using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHomeBobby.Contracts.Events;

namespace SmartHomeBobby.Contracts.Modules.LLMModule
{
    public class LLMResponseEvent : EventBase
    {
        public required string Response { get; init; }
        public TimeSpan GenerationTime { get; init; }
    }
}
