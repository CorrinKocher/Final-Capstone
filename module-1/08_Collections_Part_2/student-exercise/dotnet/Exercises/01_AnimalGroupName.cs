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
            AnimalGroupName.Add("rhino", "Crash");
            AnimalGroupName.Add("giraffe", "Tower");
            AnimalGroupName.Add("elephant", "Herd");
            AnimalGroupName.Add("lion", "Pride");
            AnimalGroupName.Add("crow", "Murder");
            AnimalGroupName.Add("pigeon", "Kit");
            AnimalGroupName.Add("flamingo", "Pat");
            AnimalGroupName.Add("deer", "Herd");
            AnimalGroupName.Add("dog", "Pack");
            AnimalGroupName.Add("crocodile", "Float");
            //Console.WriteLine();
            //Console.WriteLine("Welcome to the Animal Group Name Generator! Please enter an animal name!");
            
            if(animalName != null)
            {
                animalName = animalName.ToLower ();
                if (AnimalGroupName.ContainsKey(animalName))
                {
                    
                    return AnimalGroupName[animalName];

                }
                else
                {
                    return "unknown";
                }
                
            }
            return "unknown";



        }
    }
}
