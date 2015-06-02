using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class InsulinDose : Entity<InsulinDose, InsulinDosePage, InsulinDosePageModel>
    {
        public DateTime Timestamp { get; set; }
        public int Insulin { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Insulin} IU";
        }
    }
}
