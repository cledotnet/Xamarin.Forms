using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cleveland.DotNet.Sig.DiabetesLog.Android.Services;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Environment = System.Environment;

// For more information, see http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/files/
//
[assembly: Dependency(typeof(FileRepository))]
namespace Cleveland.DotNet.Sig.DiabetesLog.Android.Services
{
    public class FileRepository : Repository
    {
        public void SaveText(string filespec, string contents)
        {
            var path = Path.Combine(DefaultPath, filespec);
            File.WriteAllText(path, contents);
        }

        public string LoadText(string filespec)
        {
            var path = Path.Combine(DefaultPath, filespec);
            return File.ReadAllText(path);
        }

        public IEnumerable<string> GetFiles(string path)
        {
            var folder = new DirectoryInfo(path);
            if (!folder.Exists)
                folder.Create();
            return folder.GetFiles().Select(file => file.FullName);
        }

        public string GetPath(Persistable entity)
        {
            return GetPath(entity?.GetType());
        }

        public Persistable Get<EntityType>(string identifier)
            where EntityType : Persistable, new()
        {
            var filespec = BuildFilespec(typeof(EntityType), identifier);
            var json = File.ReadAllText(filespec);
            return JsonConvert.DeserializeObject<EntityType>(json);
        }

        public string Save(Persistable entity)
        {
            var filespec = BuildFilespec(entity);
            var contents = JsonConvert.SerializeObject(entity);
            SaveText(filespec, contents);
            return entity.Identifier;
        }

        private string BuildFilespec(Persistable entity)
        {
            return BuildFilespec(entity.GetType(), entity.Identifier);
        }

        private string BuildFilespec(Type type, string identifier)
        {
            var path = GetPath(type);
            var name = $"{identifier}.json";
            var filespec = Path.Combine(path, name);
            return filespec;
        }

        private string GetPath(Type type)
        {
            if (type != null)
                return Path.Combine(DefaultPath, type.Name.ToLower());
            else 
                return DefaultPath;
        }

        public IEnumerable<EntityType> Get<EntityType>(Func<EntityType, bool> filter = null) where EntityType : Persistable, new()
        {
            var path = GetPath(typeof (EntityType));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach (var file in Directory.GetFiles(path))
            {
                var entity = new EntityType();
                entity.Load(file);
                yield return entity;
            }
        }

        public string DefaultPath { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "objects"); } }
    }
}