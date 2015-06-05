using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	public abstract class DatedEvent<EntityType, ViewType, ViewModelType> : Entity<EntityType, ViewType, ViewModelType>, Editable 
		where EntityType : class, Entity, Cloneable<EntityType>, new() 
		where ViewType : BasePage<ViewModelType>, new() 
		where ViewModelType : EntityViewerViewModel<EntityType>, new()
	{
		private DateTime _date = DateTime.Now;
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

		public override string Identifier { get { return string.Format ("{0:yyyy-MM-dd HHmmss}", Timestamp); } }
		public abstract Page CreateEditor();
		public abstract bool IsChanged { get; }
	}
}
