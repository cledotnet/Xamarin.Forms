using System;
using System.Linq;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
{
    public abstract class BasePage<ViewModelType> : ContentPage
        where ViewModelType : BaseViewModel, new()
    {
        public BasePage() : this(new ViewModelType()) { }

        public BasePage(ViewModelType model)
        {
            InitializeModel(model);
            addToolbarItem("GlucoseCheck", "Diabetes-25.png", "Diabetes.png", "Images/edit.png", GlucoseCheck_Clicked);
            addToolbarItem("InsulinDose", "Syringe Filled-25.png", "Syringe.png", "Images/search.png", InsulinDose_Clicked);
            addToolbarItem("Meal", "Meal Filled-25.png", "Meal.png", "Images/refresh.png", Meal_Clicked);
            addToolbarItem("Home", "Diabetes Monitor.png", "Monitor.png", "Images/edit.png", Home_Clicked);
        }

        public virtual void InitializeModel(ViewModelType model)
        {
            BindingContext = model;
        }

		public ViewModelType Model { get { return BindingContext as ViewModelType; } }

        private async void Home_Clicked(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new HomePage()));
        }

        private async void Meal_Clicked(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new MealViewer()));
        }

        private async void InsulinDose_Clicked(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new InsulinDoseViewer()));
        }

        private async void GlucoseCheck_Clicked(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new GlucoseCheckViewer()));
        }

        private void addToolbarItem(string text, string iOSIcon, string androidIcon, string winIcon, EventHandler onClick)
        {
            var item = new ToolbarItem();
            item.Text = text;
            item.Order = ToolbarItemOrder.Primary;
            Device.OnPlatform(iOS: () => item.Icon = iOSIcon,
                Android: () => item.Icon = androidIcon,
                WinPhone: () => item.Icon = winIcon);
            item.Clicked += onClick;
            var previous = ToolbarItems.FirstOrDefault(i => i.Text == text);
            if (previous != default(ToolbarItem))
                ToolbarItems.Remove(previous);
            ToolbarItems.Insert(0, item);
        }
    }
}
