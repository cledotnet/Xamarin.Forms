using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck, GlucoseCheckViewer, GlucoseCheckPageModel>, Editable
    {
        public DateTime Timestamp { get; set; }
        public int Glucose { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Glucose} mg/dl";
        }

        public Page CreateEditor()
        {
            return new GlucoseCheckEditor(new GlucoseCheckPageModel(this));
        }
    }
}
