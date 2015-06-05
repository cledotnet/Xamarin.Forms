using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public class EntityViewerViewModel<EntityType> : BaseViewModel
		where EntityType : class, Entity, Cloneable<EntityType>, new()
	{
		private EntityType _entity;

		public EntityType Entity
		{
			get { return _entity; }
			set
			{
				if (Equals(value, _entity)) return;
				_entity = value;
				OnPropertyChanged();
			}
		}

		internal void InitializeProperties(EntityType entity)
		{
			Original = entity.Clone();
			Entity = entity;
			base.InitializeProperties();
		}

		public override void Reset()
		{
			Entity = Original.Clone();
		}

		public EntityType Original { get; private set; }
	}
}
