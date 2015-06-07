using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class GlucoseCheck : DatedEvent<GlucoseCheck, GlucoseCheckViewer, GlucoseCheckPageModel>
	{
		private int _glucose = 0;

		[JsonProperty]
		public int Glucose
		{
			get { return _glucose; }
			set
			{
				if (_glucose == value) return;
				_glucose = value;
				OnPropertyChanged();
			}
		}

		public override string ToString()
		{
			return string.Format("Check: {0} {1} mg/dl", Identifier, Glucose);
		}

		public override Page CreateEditor()
		{
			return new GlucoseCheckEditor(new GlucoseCheckPageModel(this));
		}

		public override bool IsChanged { get { return _isChanged;} }
	}
}
