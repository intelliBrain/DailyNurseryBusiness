using dnb.Core.Services;
using MvvmCross.Core.ViewModels;

namespace dnb.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculation m_calculation;
        public TipViewModel(ICalculation calculation)
        {
            m_calculation = calculation;
        }

        public override void Start()
        {
            m_subTotal = 100;
            m_generosity = 10;
            Recalcuate();
            base.Start();
        }

        private double m_subTotal;
        public double SubTotal
        {
            get { return m_subTotal; }
            set { m_subTotal = value; RaisePropertyChanged(() => SubTotal); Recalcuate(); }
        }

        private int m_generosity;
        public int Generosity
        {
            get { return m_generosity; }
            set { m_generosity = value; RaisePropertyChanged(() => Generosity); Recalcuate(); }
        }

        private double m_tip;
        public double Tip
        {
            get { return m_tip; }
            set { m_tip = value; RaisePropertyChanged(() => Tip); }
        }

        private void Recalcuate()
        {
            Tip = m_calculation.TipAmount(SubTotal, Generosity);
        }
    }
}
