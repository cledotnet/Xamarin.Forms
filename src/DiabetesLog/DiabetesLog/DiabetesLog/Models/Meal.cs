using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Meal : DatedEvent<Meal, MealViewer, MealPageModel>
	{
		[JsonProperty]
		public string Name { get; set; }
		[JsonProperty]
		public int Carbohydrates { get; set; }

		public override string ToString()
		{
			return string.Format("{2}: {0} {1} carbs", Identifier, Carbohydrates, Name);
		}

		public override Page CreateEditor()
		{
			return new MealEditor(new MealPageModel(this));
		}

		public override bool IsChanged { get { return _isChanged; } }
	}
}
