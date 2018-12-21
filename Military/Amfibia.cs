using System;

namespace Military
{
    public class Amfibia : Vehicle, ISwimmable, IDriveable
    {
        public Amfibia(int id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 30, 6)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public double Swim(int distance)
        {
            var doubleDistance = (double)distance;
            var distanceInTenMinutes = countDistance();
            var r = new Random();
            var prolongationOfTheRoad = 0;
            do
            {
                var chance = r.Next(101);
                if (chance <= 50)
                {
                    prolongationOfTheRoad += 3; // add 3 more km to prolongationOfTheRoad
                }
                doubleDistance -= distanceInTenMinutes; // take off distance that it makes in 10 minutes of distance we already calculated chance
            } while (distance > 0);
            return distance + prolongationOfTheRoad;
        }

        public double countDistance()
        {
            // distance in km = AverageSpeed km/h * 1/6 h(10 min) 
            return AverageSpeed * (1 / 6);
        }
        public int Move(int distance)
        {
            var r = new Random();
            var prolongationOfTheRoad = 0;
            do
            {
                var chance = r.Next(101);
                if (chance <= 30)
                {
                    prolongationOfTheRoad += 5; // add 5 more km to prolongationOfTheRoad
                }

                distance -= 10; // take off 10 km of distance we already calculated chance

            } while (distance > 0);

            return distance + prolongationOfTheRoad;
        }
    }
}
