using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Annotations;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
	public interface Entity : Listable, Persistable, Viewable, INotifyPropertyChanged
	{
	}

	public abstract class Entity<EntityType, ViewerType, ViewModelType> : Entity, Cloneable<EntityType>
		where EntityType : class, Entity, Cloneable<EntityType>, new()
		where ViewerType : BasePage<ViewModelType>, new() 
		where ViewModelType : EntityViewerViewModel<EntityType>, new()
	{
		private readonly Repository _repository = DependencyService.Get<Repository>();

		public Entity()
		{
		}

		public string Save()
		{
			return _repository.Save(this);
		}

		public abstract string Identifier { get; }

		public virtual string Text
		{
			get { return ToString(); }
		}

		public Page CreateViewer()
		{
			var viewer = new ViewerType();
			var viewmodel = new ViewModelType();
			viewmodel.InitializeProperties(this as EntityType);
			viewer.InitializeModel(viewmodel);
			return viewer;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected bool _isChanged = false;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null) {
				PropertyChanged.Invoke (this, new PropertyChangedEventArgs (propertyName));
			}
			_isChanged = true;
		}

		public EntityType Clone()
		{
			var json = JsonConvert.SerializeObject(this);
			return JsonConvert.DeserializeObject<EntityType>(json);
		}
	}
}
