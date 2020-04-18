using System;
using State;
using State.Read;
using State.Service;

namespace Main
{
    public class Application
    {
        private readonly IStateReader stateReader;
        private readonly IStateUpdateService stateUpdaterService;
        
        public Application(IStateUpdateService stateUpdaterService, IStateReader stateReader)
        {
            //Can' inject a IStateStore directly, oh noo I have to play by the rules and use below classes
            this.stateUpdaterService = stateUpdaterService;
            this.stateReader = stateReader;
        }
        public void Main()
        {
            Console.WriteLine(stateReader.State);
            stateUpdaterService.UpdateState();
            Console.WriteLine(stateReader.State);
        }
    }
}