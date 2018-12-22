using System;
using System.Runtime.InteropServices.ComTypes;

namespace Military
{
    public class Tank : Vehicle , IDriveable
    {
        public double totalFuelConsumption { get; set; }
        
        public Tank(int id, double weight, double averageSpeed)
        : base(id,weight,averageSpeed,30,6)
        {
            
        }

        public override void Print()
        {
            base.Print();
            Console.Write($" | Total Fuel Consumption{totalFuelConsumption}");
        }


        public override void NewTrip(int soldiers, int groundDistance)
        {
      
            totalFuelConsumption= CalculateHowManyTrips(soldiers) * CalculateFuelForTheTrip(Move(groundDistance));
            
            Print();

        }
        public int Move(int distance)
        { 
          
            var prolongationOfTheRoad = 0;
            var distanceCopy = distance*2;
            do
            {
                if (NecessaryMethods.ProbabilityOfThirtyPercent() == true)
                {
                    
                    prolongationOfTheRoad += 5; // add 5 more km to prolongationOfTheRoad
                  
                }                  
                distanceCopy -= 10; // take off 10 km of distance we already calculated chance
            } while (distanceCopy > 0);
           
            return distance*2 + prolongationOfTheRoad;
        }


    }
    }

