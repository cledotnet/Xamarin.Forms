using System;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class Meal : Entity<Meal>
    {
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public int Carbohydrates { get; set; }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Carbohydrates} carbs for {Name}";
        }
    }
}
