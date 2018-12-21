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
        public virtual void Print()
        {
            Console.Write($"ID: {ID} | Weight: {Weigth} | AverageSpeed: {AverageSpeed} " +
                          $"| FuelConsumption: {FuelConsumption} + | Capacity: {Capacity}");

        }
    }
}
