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
            var path = VerifyPath(filespec);
            File.WriteAllText(path, contents);
        }

        private string VerifyPath(string filespec)
        {
            var file = new FileInfo(filespec);
            if (file.Directory == null)
            {
                file = new FileInfo(Path.Combine(DefaultPath, filespec));
            }

            var folder = file.DirectoryName ?? Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, file.Name);
            return path;
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
                var json = File.ReadAllText(file);
                try
                {
                    entity = JsonConvert.DeserializeObject<EntityType>(json);
                }
                catch
                {
                    // TODO: Handle exceptions
                }
                yield return entity;
            }
        }

        public string DefaultPath { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "objects"); } }
    }
}