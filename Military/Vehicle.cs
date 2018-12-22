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
            ID = id;
            Weigth = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
        }
        protected virtual void Print()
        {
            Console.WriteLine($"ID: {ID} | Weight: {Weigth} | Average Speed {AverageSpeed} | Fuel Consumption {FuelConsumption}" +
                              $"| Capacity { Capacity}");
        }
        public virtual void NewTrip(int soldiers, int groundOrWaterDistance)
        {
            
        }
        public virtual void NewTrip(int soldiers, int groundDistance, int waterDistance)
        {

        }

        protected double CalculateFuelForTheTrip(int totalDistance)
        {
          
            double x = (double)totalDistance / 100 * FuelConsumption;             
            return x;
        }

        protected int CalculateHowManyTrips(int soldiers)
        {
            var howManyTrips=0;
            if (soldiers % Capacity != 0)
            {
                howManyTrips = soldiers / Capacity + 1;
                
            }              
            else
            {
                howManyTrips = soldiers / Capacity;
            }
            
            return howManyTrips;
        }

        

        
    }
}
