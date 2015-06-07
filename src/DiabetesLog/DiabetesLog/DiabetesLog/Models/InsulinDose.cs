using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class InsulinDose : DatedEvent<InsulinDose, InsulinDoseViewer, InsulinDosePageModel>, Editable
	{
		private int _insulin;

		[JsonProperty]
		public int Insulin
		{
			get { return _insulin; }
			set
			{
				if (value == _insulin) return;
				_insulin = value;
				OnPropertyChanged();
			}
		}

		public override string ToString()
		{
			return string.Format("Insulin: {0} {1} IU", Identifier, Insulin);
		}

		public override Page CreateEditor()
		{
			return new InsulinDoseEditor(new InsulinDosePageModel(this));
		}

		public override bool IsChanged { get { return _isChanged; } }
	}
}
