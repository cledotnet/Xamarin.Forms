using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
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
