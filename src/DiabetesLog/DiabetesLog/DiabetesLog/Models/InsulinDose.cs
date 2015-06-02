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
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Insulin} IU";
        }

        public override string Identifier => $"{Timestamp:yyyy-MM-dd HHmmss}";

    }
}
