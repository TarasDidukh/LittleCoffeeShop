using LittleCoffeeShop.Core.Configuration.Startup;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace LittleCoffeeShop.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, MvxAppExtendedStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();
            RegisterAppStart(appStart);
        }
    }
}
