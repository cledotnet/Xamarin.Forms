using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
    public partial class GlucoseCheckEditor : EntityEditor<GlucoseCheckPageModel, GlucoseCheck>
    {
        public GlucoseCheckEditor() : this(new GlucoseCheckPageModel())
        {
        }

        public GlucoseCheckEditor(GlucoseCheckPageModel model)
        {
            InitializeComponent();
            InitializeModel(model);
        }
    }
}
