using System.Reflection;
using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace AndroidTests
{
    [Activity(Label = "AndroidTests", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : TestSuiteActivity
    {
        private static Bundle _bundle;
        private static MainActivity _instance;

        protected override void OnCreate(Bundle bundle)
        {
            _bundle = bundle;
            _instance = this;

	        Xamarin.Forms.Forms.Init(this, bundle);

            // tests can be inside the main assembly
            AddTest(Assembly.GetExecutingAssembly());
            // or in any reference assemblies
            // AddTest (typeof (Your.Library.TestClass).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
            base.OnCreate(bundle);
        }

        public static MainActivity Instance { get { return _instance; } }
    }
}

