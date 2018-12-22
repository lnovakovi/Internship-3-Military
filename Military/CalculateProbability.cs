using System;

namespace Military
{
    public static class CalculateProbability
    {
        
        public static bool ProbabilityOfThirtyPercent()
        {
            var r = new Random();
            var chance= r.Next(1,11);  
            
            return (chance <= 3);
        }
        public static bool ProbabilityOfFiftyPercent()
        {
            var r = new Random();
            var chance = r.Next(1,11);
            return (chance <= 5);
        }
    }
}
