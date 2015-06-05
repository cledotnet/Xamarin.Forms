using System;
using System.Linq;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
	public class EntityEditor<ViewModelType, EntityType> : BasePage<ViewModelType> 
		where ViewModelType : EntityViewerViewModel<EntityType>, new() 
		where EntityType : class, Entity, Cloneable<EntityType>, new()
	{
		public EntityEditor()
		{
			
		}

		protected void Reset()
		{
			Model.Reset();
		}


		protected void Save(Persistable original = null)
		{
			var entity = Model.Entity as Persistable;
			if (entity == default(Persistable)) return;

			var repository = DependencyService.Get<Repository>();

			if (original != null)
				repository.Delete(original);

			repository.Save(entity);
			InitializeModel(Model);
		}

	}
}
