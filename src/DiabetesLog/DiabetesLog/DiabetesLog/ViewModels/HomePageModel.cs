using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
    public class HomePageModel : BaseViewModel
    {
        protected override void InitializeProperties()
        {
            Title = "Welcome to the Cleveland .NET SIG";
            OnPropertyChanged(nameof(Title));
            Introduction =
                "This is a very simple application, that I wrote for my diabetic son, to keep track of his glucose readings, carbohydrate consumption, and insulin doses. I thought this would be a good demonstration of Xamarin.Forms to share a single code base across multiple device platforms.";
            OnPropertyChanged(nameof(Introduction));
        }
    }
}
