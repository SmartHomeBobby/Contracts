using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHomeBobby.Contracts.Events;

namespace SmartHomeBobby.Contracts.Modules.LLMModule
{
    public class LLMRequestEvent : EventBase
    {
        public required string Request { get; init; }
        public required LLMRequestType RequestType { get; init; }
    }

    public enum LLMRequestType
    {
        General,
        CodeGeneration,
        CodeExplanation,
    }
}
