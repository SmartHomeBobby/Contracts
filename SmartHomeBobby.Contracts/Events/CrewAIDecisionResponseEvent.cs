using System;

namespace SmartHomeBobby.Contracts.Events
{
    /// <summary>
    /// Response sent by the stakeholder answering the blocked CrewAI agent.
    /// Topic: smarthomebobby/crewai/decision/response
    /// </summary>
    public class CrewAIDecisionResponseEvent : EventBase
    {
        /// <summary>
        /// The answer to the agent's question which will unblock it.
        /// </summary>
        public required string Answer { get; init; }
    }
}
