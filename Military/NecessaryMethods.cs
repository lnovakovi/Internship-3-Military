using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class NecessaryMethods
    {
        
        static public bool ProbabilityOfThirtyPercent()
        {
            var r = new Random();
            var chance= r.Next(31);
            return (chance <= 30);
        }
        static public bool ProbabilityOfFiftyPercent()
        {
            var r = new Random();
            var chance = r.Next(51);
            return (chance <= 50);
        }
    }
}
