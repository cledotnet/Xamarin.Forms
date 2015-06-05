using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	public class GlucoseCheck : Entity<GlucoseCheck, GlucoseCheckViewer, GlucoseCheckPageModel>, Editable
	{
		private DateTime _date = DateTime.Now;
		private int _glucose = 0;
		private TimeSpan _time;

		public DateTime Date
		{
			get { return _date; }
			set
			{
				if (_date == value) return;
				_date = value;
				OnPropertyChanged();
			}
		}

		public TimeSpan Time
		{
			get { return _time; }
			set
			{
				if (value.Equals(_time)) return;
				_time = value;
				OnPropertyChanged();
			}
		}

		public DateTime Timestamp
		{
			get { return Date + Time; }
			set
			{
				Date = value.Date;
				Time = value.TimeOfDay;
			}
		}

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

		public Page CreateEditor()
		{
			return new GlucoseCheckEditor(new GlucoseCheckPageModel(this));
		}

		public bool IsChanged { get { return _isChanged;} }

		public override string Identifier { get { return string.Format ("{0:yyyy-MM-dd HHmmss}", Timestamp); } }
	}
}
