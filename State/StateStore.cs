namespace State
{
    internal interface IStateStore
    {
        State State { get; set; }
    }

    internal class StateStore : IStateStore
    {
        public State State { get; set; }
        
        public StateStore()
        {
            State = new State();
        }
    }
}