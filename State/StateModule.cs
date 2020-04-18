using Autofac;
using State.Read;
using State.Service;

namespace State
{
    public class StateModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StateReader>().As<IStateReader>();
            builder.RegisterType<StateUpdateService>().As<IStateUpdateService>();
            
            //IStateStore is internal, no other projects can access it
            builder.RegisterType<StateStore>().As<IStateStore>().SingleInstance();
        }
    }
}