using System;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class Meal
    {
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public int Carbohydrates { get; set; }
    }
}
