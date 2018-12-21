using System;
using System.Runtime.InteropServices.ComTypes;

namespace Military
{
    public class Tank : Vehicle , IDriveable
    {
        
        public Tank(int id, double weight, double averageSpeed)
        : base(id,weight,averageSpeed,30,6)
        {
            
        }


        
        protected override int NewTrip(int soldiers, int groundDistance, int waterDistance = 0)
        {
            //var trips = CalculateHowManyTrips(soldiers);
            ////calling method from abstract class (calculated distance with all the obstacles )
            //var totalFuelConsumption = CalculateFuelForTheTrip(Move(groundDistance));

            return CalculateHowManyTrips(soldiers) * CalculateFuelForTheTrip(Move(groundDistance));

        }
        public int Move(int distance)
        {
            
            var prolongationOfTheRoad = 0;
            var distanceCopy = distance;
            do
            {
                if (NecessaryMethods.ProbabilityOfThirtyPercent())
                    prolongationOfTheRoad += 5; // add 5 more km to prolongationOfTheRoad

                distance -= 10; // take off 10 km of distance we already calculated chance

            } while (distance > 0);

            return distanceCopy + prolongationOfTheRoad;
        }


    }
    }

