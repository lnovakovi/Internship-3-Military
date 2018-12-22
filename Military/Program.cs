﻿using System;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new Tank(1,5000,60);
            var warship = new Warship(2,20000,40);
            var amfibia = new Amfibia(3,10000,55);

            var distanceForTheTank = UtilityClass.TryParseInt("Please enter distance for the tank: ");
            var distanceForTheWarship = UtilityClass.TryParseInt("Please enter distance for the warship: ");
            Console.WriteLine("Now you will enter distance for amfibia.\nFirst ground then water distance");
            var groundDistance = UtilityClass.TryParseInt("Enter ground distance: ");
            var waterDistance = UtilityClass.TryParseInt("Now water distance: ");
            var numberOfSoldiers = UtilityClass.TryParseInt("Enter number of soldiers: ");
            if (groundDistance + waterDistance < distanceForTheTank &&
                groundDistance + waterDistance < distanceForTheWarship)
            {
                tank.NewTrip(numberOfSoldiers, distanceForTheTank);
                warship.NewTrip(numberOfSoldiers, distanceForTheWarship);
                amfibia.NewTrip(numberOfSoldiers, groundDistance, waterDistance);
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }


        }
    }
}
