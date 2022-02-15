using Autofac;
using FriendZone.UI.Services;
using FriendZone.UI.ViewModels;

namespace FriendZone.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendZoneService>().As<IFriendZoneService>();

            return builder.Build();
        }
    }
}
