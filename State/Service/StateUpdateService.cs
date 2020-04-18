using System;

namespace State.Service
{
    /*
     * I need to LOCK DOWN any updates to the State in StateStore through this class
     * NOBODY can directly access state store and change values willy nilly
     */
    internal class StateUpdateService : IStateUpdateService
    {
        private readonly IStateStore stateStore;
        
        public StateUpdateService(IStateStore stateStore)
        {
            this.stateStore = stateStore;
        }

        public void UpdateState()
        {
            var random = new Random();
            stateStore.State.Counter = random.Next();
            stateStore.State.Name = random.Next().ToString();
        }
    }
}