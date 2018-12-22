using System;

namespace Military
{
    public class Amfibia : Vehicle, ISwimmable, IDriveable
    {
        private double totalFuelConsumption { get; set; }
        public Amfibia(int id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 200, 50)
        {

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" | Total Fuel Consumption: {totalFuelConsumption}");
        }

        public override void NewTrip(int soldiers, int groundDistance, int waterDistance)
        {
           
            totalFuelConsumption = CalculateHowManyTrips(soldiers) *
                                   CalculateFuelForTheTrip(Move(groundDistance) + Swim(waterDistance));
            Print();
        }

        public int Swim(int distance)
        {
            var doubleDistance = (double)distance*2;
            var distanceInTenMinutes = countDistance();          
            var prolongationOfTheRoad = 0;
            do
            {
               
                if (NecessaryMethods.ProbabilityOfFiftyPercent() == true)
                {
                    prolongationOfTheRoad += 3; // add 3 more km to prolongationOfTheRoad
                }
                doubleDistance -= distanceInTenMinutes; // take off distance that it makes in 10 minutes of distance we already calculated chance
            } while (doubleDistance > 0);
            return distance*2 + prolongationOfTheRoad;
        }

        public double countDistance()
        {
            // distance in km = AverageSpeed km/h * 1/6 h(10 min) 
            return AverageSpeed * 0.167;
        }
        public int Move(int distance)
        {
           
            var prolongationOfTheRoad = 0;
            var distanceCopy = distance*2;
            do
            {
               
                if (NecessaryMethods.ProbabilityOfThirtyPercent()== true)
                {
                    prolongationOfTheRoad += 5; // add 5 more km to prolongationOfTheRoad
                }

                distanceCopy -= 10; // take off 10 km of distance we already calculated chance

            } while (distanceCopy > 0);

            return distance*2 + prolongationOfTheRoad;
        }
    }
}
