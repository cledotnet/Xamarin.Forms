using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck, GlucoseCheckPage, GlucoseCheckPageModel>
    {
        public DateTime Timestamp { get; set; }
        public int Glucose { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Glucose} mg/dl";
        }
    }
}
