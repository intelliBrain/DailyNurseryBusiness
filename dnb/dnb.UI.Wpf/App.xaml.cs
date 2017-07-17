using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Wpf.Views;
using System.Windows;

namespace dnb.UI.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private bool m_setupComplete = false;

        private void DoSetup()
        {
            var presenter = new MvxSimpleWpfViewPresenter(MainWindow);

            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            m_setupComplete = true;
        }

        protected override void OnActivated(System.EventArgs e)
        {
            if (!m_setupComplete)
                DoSetup();

            base.OnActivated(e);
        }
    }
}
