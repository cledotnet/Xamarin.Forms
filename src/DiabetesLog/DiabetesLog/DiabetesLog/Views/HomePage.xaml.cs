using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
{
    public partial class HomePage : BasePage<HomePageModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            if (args.Item is Editable)
            {
                var editor = ((Editable)args.Item).CreateEditor();
                await this.Navigation.PushModalAsync(new NavigationPage(editor));
            }
            else if (args.Item is Viewable)
            {
                var viewer = ((Viewable)args.Item).CreateViewer();
                await this.Navigation.PushModalAsync(new NavigationPage(viewer));
            }
        }
    }
}
