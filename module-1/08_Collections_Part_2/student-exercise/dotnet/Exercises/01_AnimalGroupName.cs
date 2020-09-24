using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> AnimalGroupName = new Dictionary<string, string>();
            AnimalGroupName.Add("Rhino", "crash");
            AnimalGroupName.Add("Giraffe", "tower");
            AnimalGroupName.Add("Elephant", "herd");
            AnimalGroupName.Add("Lion", "pride");
            AnimalGroupName.Add("Crow", "murder");
            AnimalGroupName.Add("Pigeon", "kit");
            AnimalGroupName.Add("Flamingo", "pat");
            AnimalGroupName.Add("Deer", "herd");
            AnimalGroupName.Add("Dog", "pack");
            AnimalGroupName.Add("Crocodile", "float");
            //Console.WriteLine();
            //Console.WriteLine("Welcome to the Animal Group Name Generator! Please enter an animal name!");
            
            string requestedAnimal = animalName.ToLower();
            string value = "";
            if (AnimalGroupName.ContainsKey(requestedAnimal))
            {
                foreach (KeyValuePair<string, string> kvp in AnimalGroupName)
                {
                    value = kvp.Value;
                   
                }
                return value;
            }
            return "unknown";
        }
    }
}
