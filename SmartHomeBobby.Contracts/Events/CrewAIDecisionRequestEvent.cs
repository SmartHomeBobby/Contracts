using System;

namespace SmartHomeBobby.Contracts.Events
{
    /// <summary>
    /// Event sent by a CrewAI agent when it is blocked and requires a decision from the stakeholder.
    /// Topic: smarthomebobby/crewai/decision/request
    /// </summary>
    public class CrewAIDecisionRequestEvent : EventBase
    {
        /// <summary>
        /// The specific question the agent needs answered.
        /// </summary>
        public required string Question { get; init; }

        /// <summary>
        /// Any context, code snippets, or alternative choices necessary for the stakeholder to make a decision.
        /// </summary>
        public required string Context { get; init; }
    }
}
