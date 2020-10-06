using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
namespace WordSearch
{
    public class WordSearchApp
    {
        //public WordSearchApp(string wordToPrint, string printedWords)
        //{
        //    this.WordToPrint = wordToPrint;
        //    this.PrintedWords = printedWords;
        //}
        public void Run()
        {
            //1. Ask the user for the search string            
            Console.WriteLine("Please provide a text file to search for");
            string searchPhrase = Console.ReadLine();
            //2. Ask the user for the file path
            Console.WriteLine();
            Console.WriteLine("Please provide the path to the file");
            string filePath = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Should the search be case sensitive? Y/N");
            string isSensitive = Console.ReadLine();
            //3. Open the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineCounter = 1;

                if (isSensitive.Contains("N"))
                {
                    //4. Loop through each line in the file
                    while (!reader.EndOfStream) //&& reader.ReadLine() != null
                    {

                        string line = lineCounter++ + ")" + reader.ReadLine();
                        {
                            if (line.Contains(searchPhrase))
                            {
                                continue;
                                //line = line.Replace(this.WordToCensor, this.CensoredText);
                                //5. If the line contains the search string, print it out along with its line number
                                //Console.WriteLine(line + "," + lineCounter);
                            }
                            Console.WriteLine(line);
                        }

                        // See Part 2 in the Readme.md file for additional changes
                    }
                }

                else if (isSensitive.Contains("Y"))
                    searchPhrase = searchPhrase.ToLower();
                {
                    //4. Loop through each line in the file
                    while (!reader.EndOfStream) //&& reader.ReadLine() != null
                    {
                        string line = lineCounter++ + ")" + reader.ReadLine();
                        {
                            if (line.Contains(searchPhrase))
                            {
                                continue;
                                //line = line.Replace(this.WordToCensor, this.CensoredText);
                                //5. If the line contains the search string, print it out along with its line number
                                //Console.WriteLine(line + "," + lineCounter);
                            }
                            Console.WriteLine(line);
                        }

                        // See Part 2 in the Readme.md file for additional changes
                    }
                }
                   
            }
        }
    }
   
    
}
