﻿using System;
using System.Collections.Generic;

namespace lists
{
    public class Program
    {
        public static void Main()
        {
            var planetList = new List<string>() {
                "Mercury",
                "Mars"
            };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            var morePlanets = new List<string>() {
                "Neptune",
                "Uranus"
            };

            planetList.AddRange(morePlanets);

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            planetList.Insert(3, "Earth");
            planetList.Insert(4, "Venus");
            planetList.Add("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            List<string> rockyPlanets = planetList.GetRange(2, 3);

            foreach (string rock in rockyPlanets) {
                Console.WriteLine(rock);
            }

            planetList.Remove("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }
        }
    }
}