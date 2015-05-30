using System;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
{
    public abstract class BasePage : ContentPage
    {
        public async void MealItem_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new MealPage()));
        }

        public async void InsulinDoseItem_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new InsulinDosePage()));
        }

        public async void GlucoseCheckItem_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new GlucoseCheckPage()));
        }

    }
}
