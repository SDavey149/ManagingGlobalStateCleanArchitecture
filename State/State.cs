namespace State
{
    public class State
    {
        public int Counter { get; set; }
        
        public string Name { get; set; }

        public State()
        {
        }

        public State(State state)
        {
            Counter = state.Counter;
            Name = state.Name;
            
            //obviously do a deep copy for reference types if you have any
        }

        public override string ToString()
        {
            return $"{Counter} - {Name}";
        }
    }
}