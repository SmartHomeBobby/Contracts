using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHomeBobby.Contracts.Events;

namespace SmartHomeBobby.Contracts.Workflows
{
    public abstract class WorkflowBase<TEvent>
        where TEvent : EventBase
    {
        public WorkflowBase(ISensorState sensorState)
        {
            this.sensorState = sensorState;
        }

        protected ISensorState sensorState;

        public abstract Task<bool> ShouldExecuteForEventAsync(TEvent evt);

        public abstract Task ExecuteAsync(TEvent evt);
    }
}
