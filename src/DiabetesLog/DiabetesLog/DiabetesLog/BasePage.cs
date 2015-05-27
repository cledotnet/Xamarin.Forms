using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiabetesLog
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
