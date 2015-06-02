using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck, GlucoseCheckPage, GlucoseCheckPageModel>, Editable
    {
        public DateTime Timestamp { get; set; }
        public int Glucose { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Glucose} mg/dl";
        }

        public Page CreateEditor()
        {
            throw new NotImplementedException();
        }
    }
}
