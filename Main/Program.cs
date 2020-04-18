using Autofac;
using State;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterModule(new StateModule());

            var compositionRoot = builder.Build();
            compositionRoot.Resolve<Application>().Main();
        }
    }
}