using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public interface Entity : Listable, Persistable, Viewable
    {}

    public abstract class Entity<EntityType, ViewerType, ViewModelType> : Entity
        where EntityType : class, Entity, new()
        where ViewerType : BasePage<ViewModelType>, new() 
        where ViewModelType : EntityViewerViewModel<EntityType>, new()
    {
        private readonly Repository _repository = DependencyService.Get<Repository>();
        private string _text;

        public Entity()
        {
            _text = ToString();
        }

        public virtual void Save(string path)
        {
            _repository.SaveText(path, JsonConvert.SerializeObject(this));
        }

        public virtual void Load(string path)
        {
            var json = _repository.LoadText(path);
            var instance = JsonConvert.DeserializeObject<EntityType>(json);
            foreach (var property in typeof(EntityType).GetRuntimeProperties())
            {
                var indices = property.GetIndexParameters();
                if (indices.Length == 0)
                    property.SetValue(this, property.GetValue(instance));
                else
                    throw new NotImplementedException("Indexed properties are not supported yet.");
            }
        }

        public virtual string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public Page CreateViewer()
        {
            var viewer = new ViewerType();
            var viewmodel = new ViewModelType();
            viewmodel.InitializeProperties(this as EntityType);
            viewer.InitializeModel(viewmodel);
            return viewer;
        }
    }
}
