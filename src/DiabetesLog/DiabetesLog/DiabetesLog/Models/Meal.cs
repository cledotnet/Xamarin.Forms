using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class Meal : Entity<Meal, MealViewer, MealPageModel>
    {
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public int Carbohydrates { get; set; }

        public override string ToString()
        {
			return string.Format("{0} {1} carbs for {2}", Identifier, Carbohydrates, Name);
        }

		public override string Identifier { get { return string.Format("{0:yyyy-MM-dd HHmmss}", Timestamp); } }

    }
}
