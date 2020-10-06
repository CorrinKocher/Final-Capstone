using System;
using System.IO;

namespace FileInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // First we'll want to catch exceptions from this operation
                Calculator calculator = null; // new Calculator();
                int result = calculator.Divide(42, 0);
                Console.WriteLine("42 / 0 = " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Oh noes! You divided by 0: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please give the calcvalid values: " + ex.Message);
            }



            // For practice, we'll take a look at Directory, Environment, Path, and File
            //Directory - manipulate directories and list content
            // Environment.CurrentDirectory- get the directory the file is currently running in
            string basePath = "C:\\Users";
            string myPath =Path.Combine(basePath, "Student");
            myPath = "C:\\Users\\Student\\corrinkocher-c-sharp-material\\module-1\\16_FileIO_Reading_in\\student-lecture\\dotnet";
           string[] Files = Directory.GetFiles(myPath);

            //file. gitbash is for humans. this static classesdo the same stuff for computers, and can delete etc
            // Next we're going to demonstrate working with reading files
            // C:\\Users\Student\corrinkocher-c-sharp-material\module-1\16_FileIO_Reading_in\student-lecture\dotnet 
            //manually add the extra slash in front of users
            

            CensoredFileReader censor = new CensoredFileReader("Cat", "Doggo");

            string filePath = Path.Combine(myPath,"alice.txt"); // TODO: Set this to the correct path

            // We'll want to practice working with reading files by uncommenting this line
            censor.CensorFile(filePath);

            // Allow the user to press a key
            Console.ReadLine();
        }
    }
}
