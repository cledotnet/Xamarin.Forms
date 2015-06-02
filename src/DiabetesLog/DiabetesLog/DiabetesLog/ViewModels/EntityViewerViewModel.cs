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
        where EntityType : Entity, new()
    {
        public EntityType Entity { get; set; }

        internal void InitializeProperties(EntityType entity)
        {
            Entity = entity;
            base.InitializeProperties();
        }
    }
}
