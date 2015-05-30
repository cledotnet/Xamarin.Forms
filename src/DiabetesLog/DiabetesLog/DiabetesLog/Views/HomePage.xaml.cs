using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
{
    public partial class HomePage : BasePage
    {
        public HomePage()
        {
            InitializeComponent();
            GlucoseCheckItem.Clicked += GlucoseCheckItem_Clicked;
            InsulinDoseItem.Clicked += InsulinDoseItem_Clicked;
            MealItem.Clicked += MealItem_Clicked;
        }
    }
}
