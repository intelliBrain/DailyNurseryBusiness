using dnb.Core.Services;
using dnb.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace dnb.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}
