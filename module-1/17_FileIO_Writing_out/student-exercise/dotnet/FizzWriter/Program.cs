using System;
using System.IO;
using System.Collections;
using System.Text;

namespace FizzWriter
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            string myPath = GetReadmeDir();
            string newFile = Path.Combine(myPath, "FizzBuzz.txt");
            bool shouldAppend = false;

            using (StreamWriter writer = new StreamWriter(newFile, shouldAppend))
            {
                for (int i = 1; i < 301; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        writer.WriteLine("FizzBuzz");
                    }
                    if (i % 3 == 0)
                    {
                        writer.WriteLine("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        writer.WriteLine("Buzz");
                    }
                    writer.WriteLine(i);

                }
               

            }
        }


        /// Gets the full path to the directory with the readme file
        /// </summary>
        /// <returns>The full path to the directory with the readme file</returns>
        public static string GetReadmeDir()
        {
            string dir = Environment.CurrentDirectory;

            System.IO.DirectoryInfo netcoreappDir = System.IO.Directory.GetParent(dir);
            System.IO.DirectoryInfo binDir = System.IO.Directory.GetParent(netcoreappDir.FullName);
            System.IO.DirectoryInfo codeDir = System.IO.Directory.GetParent(binDir.FullName);
            System.IO.DirectoryInfo readmeDir = System.IO.Directory.GetParent(codeDir.FullName);

            return readmeDir.FullName;
        }
    }
}
