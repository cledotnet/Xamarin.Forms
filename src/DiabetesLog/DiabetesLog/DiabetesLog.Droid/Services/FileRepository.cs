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

        public string DefaultPath { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "objects"); } }
    }
}