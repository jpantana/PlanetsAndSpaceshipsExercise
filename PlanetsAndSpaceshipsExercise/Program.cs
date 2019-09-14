using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceshipsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Neptune" };

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(2, "Earth");
            planetList.Insert(6, "Venus");

            planetList.Add("Pluto");

            planetList.Remove("Pluto");

            Dictionary<string, Array> spaceDictionary = new Dictionary<string, Array>();
            string[] planetsForPioneer = { "Jupiter" };
            string[] planetsForPioneer11 = { "Jupiter", "Saturn" };
            string[] planetsForVoyager1 = { "Jupiter", "Saturn" };
            string[] planetsForVoyager2 = { "Jupiter", "Saturn", "Uranus", "Neptune" };
            string[] planetsForNewHorizon = { "Jupiter", "Pluto" };

            spaceDictionary.Add("Pioneer 10", planetsForPioneer);
            spaceDictionary.Add("Pioneer 11", planetsForPioneer11);
            spaceDictionary.Add("Voyager 1", planetsForVoyager1);
            spaceDictionary.Add("Voyager 2", planetsForVoyager2);
            spaceDictionary.Add("New Horizon", planetsForNewHorizon);

            foreach (KeyValuePair<string, Array> item in spaceDictionary)
            {
                Console.Write($"{item.Key}: ");
                foreach (var planet in item.Value)
                {
                    Console.Write($"{planet}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
