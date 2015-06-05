using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public class EntityEditorViewModel<EntityType> : EntityViewerViewModel<EntityType> 
		where EntityType : class, Entity, Cloneable<EntityType>, new()
	{
		private string _id;

		public EntityEditorViewModel() { }

		public EntityEditorViewModel(EntityType entity)
		{
			InitializeProperties(entity);
			Id = entity.Identifier;
		}
		
		public string Id
		{
			get { return _id; }
			set
			{
				if (value == _id) return;
				_id = value;
				OnPropertyChanged();
			}
		}
	}
}
