using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordSearch
{
    public class WordSearchApp
    {
        public void Run()
        {
            //1. Ask the user for the search string
            Console.WriteLine("Please provide a text file to search for");
            string searchPhrase = Console.ReadLine();

            //2. Ask the user for the file path
            Console.WriteLine("Please provide the path to the file");
            string filePath = Console.ReadLine();

            //3. Open the file
            using (StreamReader reader = new StreamReader(filePath)
            {

            }

            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

                // See Part 2 in the Readme.md file for additional changes
        }
    }
}
