using dnb.Core.ViewModels;
using MvvmCross.Wpf.Views;

namespace dnb.UI.Wpf.Views
{
    /// <summary>
    /// Interaction logic for TipView.xaml
    /// </summary>
    public partial class TipView : MvxWpfView
    {
        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public TipView()
        {
            InitializeComponent();
        }
    }
}
