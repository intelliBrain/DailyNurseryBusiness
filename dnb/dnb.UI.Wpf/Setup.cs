using System.Windows.Threading;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views;
using MvvmCross.Core.ViewModels;

namespace dnb.UI.Wpf
{
    public class Setup : MvxWpfSetup
    {
        public Setup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter) : base(uiThreadDispatcher, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
