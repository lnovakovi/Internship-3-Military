using System;

namespace Military
{
    public class Tank : Vehicle, IDriveable
    {
        public double TotalFuelConsumption { get; set; }

        public Tank(int id, double weight, double averageSpeed)
        : base(id, weight, averageSpeed, 30, 6)
        {

        }

        protected override void Print()
        {
            base.Print();
            Console.Write($" | Total Fuel Consumption{TotalFuelConsumption}\n");
        }


        public override void NewTrip(int soldiers, int groundDistance)
        {

            TotalFuelConsumption = CalculateHowManyTrips(soldiers) * CalculateFuelForTheTrip(Move(groundDistance));
            Print();
        }
        public int Move(int distance)
        {       
            var prolongationOfTheRoad = 0;
            var distanceCopy = distance * 2;
            do
            {
                if (CalculateProbability.ProbabilityOfThirtyPercent())
                {
                    prolongationOfTheRoad += 5; // add 5 more km to prolongationOfTheRoad                  
                }
                distanceCopy -= 10; // take off 10 km of distance we already calculated chance
                
            } while (distanceCopy > 0);           
            return distance * 2 + prolongationOfTheRoad;
        }


    }
}

