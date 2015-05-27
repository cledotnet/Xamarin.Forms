using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiabetesLog
{
    public partial class InsulinDosePage : BasePage
    {
        public InsulinDosePage()
        {
            InitializeComponent();
            GlucoseCheckItem.Clicked += GlucoseCheckItem_Clicked;
            InsulinDoseItem.Clicked += InsulinDoseItem_Clicked;
            MealItem.Clicked += MealItem_Clicked;
        }
    }
}
