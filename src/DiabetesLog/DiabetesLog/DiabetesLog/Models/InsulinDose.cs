using System;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class InsulinDose : Entity<InsulinDose>
    {
        public DateTime Timestamp { get; set; }
        public int Insulin { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Insulin} IU";
        }
    }
}
