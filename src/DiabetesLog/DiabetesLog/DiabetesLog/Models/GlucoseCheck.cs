using System;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck>
    {
        public DateTime Timestamp { get; set; }
        public int Glucose { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Glucose} mg/dl";
        }
    }
}
