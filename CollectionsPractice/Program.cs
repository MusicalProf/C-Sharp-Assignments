using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three basic arrays
            // An array to hold integer values 0-9
            int[] arrayOfInts = new int[]{
               0, 1, 2, 3, 4, 5, 6, 7, 8, 9
           };

            // An array of the names Tim, Martin, Nikki, and Sara
            string[] names;
            names = new string[] { "Tim", "Martin", "Nikki", "Sara" };

            // An array of length 10 that alternates between true and false values, starting with true.
            bool[] booleans = { true, false, true, false, true, false, true, false, true, false };

            // List of Flavors
            // List of ice cream flavors that holds at least 5 different flavors. 
            List<string> iceCream = new List<string>(){
                "Butter Pecan",
                "Mint Chocolate",
                "Neopolitan",
                "Reeses Peanut Butter",
                "Vanilla",
                "Strawberry",
                "Rainbow Sherbert",
                "Rocky Road",
                "Cookies and Cream",
                "Truffle"
            };

            // Outputting the Length
            Console.WriteLine($"There are {iceCream.Count} ice cream flavors to choose from.");

            // Outputting the third flavor on the third flavor in the list, then removing. 
            Console.WriteLine($"The third flavor is {iceCream[2]}.");
            iceCream.Remove(iceCream[2]);
            Console.WriteLine($"After removal, the third flavor is now {iceCream[2]}.");

            // Outputting the new length of the list. 
            Console.WriteLine($"There are now {iceCream.Count} flavors on the list.");

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values.

            // Declaring a new random generator.
            Random rand = new Random();
            Dictionary<string, string> nameFlavors = new Dictionary<string, string>();
            // With the random value, the flavors change each time the code is ran.
            nameFlavors.Add(names[0], iceCream[rand.Next(9)]);
            nameFlavors.Add(names[1], iceCream[rand.Next(9)]);
            nameFlavors.Add(names[2], iceCream[rand.Next(9)]);
            nameFlavors.Add(names[3], iceCream[rand.Next(9)]);

            // Looping through and printing out names and associated flavors.
            foreach (KeyValuePair<string, string> entry in nameFlavors)
            {
                Console.WriteLine($"Name: {entry.Key}, Flavor: {entry.Value}");
            }
        }
    }
}
