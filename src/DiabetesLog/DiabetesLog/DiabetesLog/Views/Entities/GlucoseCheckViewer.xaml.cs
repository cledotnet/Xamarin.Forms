using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
    public partial class GlucoseCheckViewer : EntityViewer<GlucoseCheckPageModel, GlucoseCheck>
    {
        public GlucoseCheckViewer()
        {
            InitializeComponent();
        }
    }
}
