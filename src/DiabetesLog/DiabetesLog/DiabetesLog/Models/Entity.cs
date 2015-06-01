using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public interface Entity : Listable, Persistable
    {}

    public abstract class Entity<EntityType> : Entity
        where EntityType : Entity, new()
    {
        private readonly Repository _repository = DependencyService.Get<Repository>();

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
    }
}
