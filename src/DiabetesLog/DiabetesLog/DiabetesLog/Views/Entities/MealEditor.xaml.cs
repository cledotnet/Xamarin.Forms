using System;
using System.IO;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
	public partial class MealEditor : EntityEditor<MealPageModel, Meal>
	{
		public MealEditor() : this(new MealPageModel())
		{
		}

		public MealEditor(MealPageModel model)
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
