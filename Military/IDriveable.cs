using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Military
{
    public interface IDriveable
    {
        void Move(int distance)
        {
            var r = new Random();
            do
            {
                var chance = r.Next(101);
                if (chance <= 30)
                {
                    distance += 5; // add 5 more km to distance
                }

                distance -= 10; // take off 10 km of distance we already calculated chance

            } while (distance > 0);

        }


    }
}
