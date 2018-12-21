using System;

namespace Military
{
    public abstract class Vehicle 
    {
        public int ID { get; set; }
        public double Weigth { get; set; }
        public double AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        protected Vehicle(int id,double weight,double averageSpeed, int fuelConsumption,int capacity)
        {
            
        }

       
        protected virtual int NewTrip(int soldiers, int groundDistance, int waterDistance = 0)
        {
            return 0; //just to return int
        }

        public int CalculateFuelForTheTrip(int totalDistance)
        {
            return totalDistance / 100 * FuelConsumption;
        }

        protected int CalculateHowManyTrips(int soldiers)
        {
            var howManyTrips = 0;
            if (soldiers / Capacity != 0)
                howManyTrips = soldiers / Capacity + 1;
            else
            {
                howManyTrips = soldiers / Capacity;
            }
            return howManyTrips;
        }

        

        
    }
}
