using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class InsulinDose : Entity<InsulinDose, InsulinDoseViewer, InsulinDosePageModel>
    {
        public DateTime Timestamp { get; set; }
        public int Insulin { get; set; }

        public override string ToString()
        {
			return string.Format("{0} {1} IU", Identifier, Insulin);
        }

		public override string Identifier { get { return string.Format("{0:yyyy-MM-dd HHmmss}", Timestamp); } }

    }
}
