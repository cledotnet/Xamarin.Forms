using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Annotations;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		private string _title;
		private string _introduction;

		public BaseViewModel()
		{
			InitializeProperties();
		}

		public virtual void InitializeProperties()
		{
			Title = this.GetType().Name;
		}

		public string Title
		{
			get { return _title; }
			set
			{
				if (_title == value) return;
				_title = value;
				OnPropertyChanged();
			}
		}

		public string Introduction
		{
			get { return _introduction; }
			set
			{
				if (value == _introduction) return;
				_introduction = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public abstract void Reset();
	}
}
