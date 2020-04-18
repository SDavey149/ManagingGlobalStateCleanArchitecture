namespace State.Read
{
    internal class StateReader : IStateReader
    {
        private readonly IStateStore store;
        
        public State State => new State(store.State);

        public StateReader(IStateStore store)
        {
            this.store = store;
        }
    }
}