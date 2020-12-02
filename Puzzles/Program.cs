using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random Array
            PrintArray(RandomArray());
            // Coin Flip
            CoinToss();
            TossMultipleCoins(10);
            // Names
            Names();
        }
        static void PrintArray(int[] arr)
        {
            // This function prints out an array in array format to the console.
            Console.Write("The current Array is: [");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[arr.Length - 1] + "]");
        }
        static object PrintList(List<string> arr)
        {
            // This function prints out an array in array format to the console.
            Console.Write("The current List is: [");
            for (int i = 0; i < arr.Count - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[arr.Count - 1] + "]");
            return arr;
        }
        static int[] RandomArray()
        {
            // Place 10 random integers (5-25) into an array.
            Random rand = new Random();
            int[] arr = new int[10];
            int num = 0;
            int idx = 0;
            while (idx < 10)
            {
                num = rand.Next(5, 26);
                arr[idx] = num;
                idx++;
            }

            // Print min and max values of the array
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            foreach (int val in arr)
            {
                if (max < val)
                    max = val;
                if (min > val)
                    min = val;
                sum += val;
            }
            Console.WriteLine($"The sum of all values in the array is {sum}.\nThe minimum value of the array is {min}\nThe maximum value of the array is {max}.");
            return arr;
        }
        static string CoinToss()
        {
            // Printing tossing a coin.
            Console.WriteLine("\nTossing a Coin");
            // Initialize a random number to handle the toss.
            Random rand = new Random();
            int num = 0;
            for (int i = 0; i < 1; i++)
            {
                num = rand.Next(1, 3);
            }
            // Print out heads or tails based on the random number.
            if (num == 1)
                Console.WriteLine("heads");
            else
                Console.WriteLine("tails");
            // Convert the number to string and return the result.
            string result = num.ToString();
            // Console.WriteLine(result);
            return result;
        }
        static double TossMultipleCoins(int num)
        {
            // Created a function that calls the CoinToss function.
            double win = 0;
            double loss = 0;
            double rate = 0;
            double ratio = 0;
            for (int i = 0; i < num; i++)
            {
                string result = CoinToss();
                if (result == "1")
                    win += 1;
                else
                    loss += 1;
            }
            // Calculate win loss ratio and win rate.
            ratio = win / loss;
            rate = (win / num) * 100;
            Console.WriteLine($"\nThe win/loss ratio is (wins:losses) {win}:{loss}.\nThe win rate is {rate}%.");
            return ratio;
        }
        static List<string> Names()
        {
            // Create the list of names
            List<string> names = new List<string>()
            {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney",
            };
            // Shuffle the list of names, and print the names in a new order.
            Random shuffle = new Random();
            int i = 0;
            while (i < names.Count)
            {
                string j = names[i];
                int val = shuffle.Next(i, names.Count);
                names[i] = names[val];
                names[val] = j;
                i++;
            }
            PrintList(names);
            List<string> fivesOnly = new List<string>();
            foreach (string name in names)
            {
                if(name.Length >= 5)
                    fivesOnly.Add(name);
                else
                    Console.WriteLine(name);
            }
            PrintList(fivesOnly);
            return fivesOnly;
        }
    }
}
