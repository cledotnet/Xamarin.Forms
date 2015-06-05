using System;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
	public partial class InsulinDoseEditor : EntityEditor<InsulinDosePageModel, InsulinDose>
	{
		public InsulinDoseEditor() : this(new InsulinDosePageModel())
		{
		}

		public InsulinDoseEditor(InsulinDosePageModel model)
		{
			InitializeComponent();
			InitializeModel(model);
		}

		public void Reset_OnClicked(object sender, EventArgs args)
		{
			Reset();
		}

		public void Save_OnClicked(object sender, EventArgs args)
		{
			Save(Model.Original);
		}
	}
}
