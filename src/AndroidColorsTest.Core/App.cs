using MvvmCross.IoC;
using MvvmCross.ViewModels;
using AndroidColorsTest.Core.ViewModels.Home;

namespace AndroidColorsTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
