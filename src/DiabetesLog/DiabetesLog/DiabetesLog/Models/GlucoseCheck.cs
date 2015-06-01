using System;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck>
    {
        public DateTime Timestamp { get; set; }
        public int Glucose { get; set; }
    }
}
