using System;

namespace Military
{
    public class Warship : Vehicle, ISwimmable
    {
        private  double TotalFuelConsumption { get; set; }

        public Warship(int id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 70, 20)
        {

        }

        protected override void Print()
        {
            base.Print();
            Console.WriteLine($" | Total Fuel Consumption{TotalFuelConsumption}\n");
            
        }
        public override void NewTrip(int soldiers, int waterDistance)
        {

            TotalFuelConsumption = CalculateHowManyTrips(soldiers) * CalculateFuelForTheTrip(Swim(waterDistance));
            Print();
        }

        public int Swim(int distance)
        {
            var doubleDistance = (double)distance*2;
            var distanceInTenMinutes = CountDistance();            
            var prolongationOfTheRoad = 0;
            do
            {                  
                if (CalculateProbability.ProbabilityOfFiftyPercent()) 
                {                   
                    prolongationOfTheRoad += 3; // add 3 more km to prolongationOfTheRoad                
                }               
                doubleDistance -= distanceInTenMinutes; // take off distance that it makes in 10 minutes of distance we already calculated chance
            } while (doubleDistance > 0);
            
            return distance*2 + prolongationOfTheRoad;
        }

        private double CountDistance()
        {
            // distance in km = AverageSpeed km/h * 1/6 h(10 min) 
           
            return AverageSpeed * 0.167;
        }
    }
}
