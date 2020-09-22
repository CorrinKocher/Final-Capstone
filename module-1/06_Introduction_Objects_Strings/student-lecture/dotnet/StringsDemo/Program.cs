using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string myName = "Matt";

            string friendName = "Matt";

           //  bool sameName = myName == friendName; // Strings use value equality

            friendName.ToUpper();
            Console.WriteLine(myName);
            Console.WriteLine(friendName);
            Console.WriteLine(friendName[3]);


            friendName = "Batman"; // Only changes my friend's name, doesn't change mine

        
           string name = "Ada Lovelace"; // strings are a reference type.

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e
            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length - 1]);
            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            // Console.WriteLine("First 3 characters: ");
            Console.WriteLine(name.Substring(0, 3));
            string[] words = name.Split(" ");
            Console.WriteLine(words[0]);

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("Last 3 Characters");
            Console.WriteLine(name.Substring(name.Length - 3, 3));


            // Console.WriteLine("Last 3 characters: ");

            // 4. What about the last word?
            // Output: Lovelace

            Console.WriteLine(words[1]);
            // Console.WriteLine("Last Word: ");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\" " + name.Contains("Love"));
            Console.WriteLine(name.StartsWith("Ada"));
            Console.WriteLine(name.EndsWith("ace"));

            // Console.WriteLine("Contains \"Love\"");

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine("Index of \"lace\": " +name.IndexOf("lace"));

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'A')
                    count++;
            }
            Console.WriteLine("number of \"a's\": " + count);

            // Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            name = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;
           // name = name.ToUpper();

            // 10. If name is equal to null or "", print out "All Done".

          //  if (name == null || name == "")
          if(string.IsNullOrEmpty(name))
           {
               Console.WriteLine("All Done!");
           }

            Console.ReadLine();
        }
    }
}