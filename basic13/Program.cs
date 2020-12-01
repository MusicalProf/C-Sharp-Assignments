using System;
using System.Collections;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] testArr2 = new int[] { -3, -7, -5, 10, 4, 6, 0, -12, -15 };
            int[] testArr3 = new int[] { 2, 10, 3 };
            int[] testArr4 = new int[] { 1, 3, 5, 7 };
            int[] testArr5 = new int[] { 1, 5, 10, -10 };
            int[] testArr6 = new int[] { 1, 5, 10, -2 };
            int[] testArr7 = new int[] { 1, 5, 10, 7, -2 };
            int[] testArr8 = new int[] { -1, -3, 2 };
            // Basic 13 Functions
            // Print 1-255
            PrintNumbers();
            // Print odd numbers between 1-255
            PrintOdds();
            // Print Sum
            PrintSum();
            // Iterating through an Array
            LoopArray(testArr1);
            // Find Max
            FindMax(testArr2);
            // Get Average
            GetAverage(testArr3);
            // Array with Odd Numbers
            OddArray();
            // Greater than Y
            GreaterThanY(testArr4, 3);
            // Square the Values
            SquareArrayValues(testArr5);
            // Eliminate Negative Numbers
            EliminateNegatives(testArr6);
            // Min, Max, and Average
            MinMaxAverage(testArr6);
            // Shifting the values in an array
            ShiftValues(testArr7);
            // Number to String
            NumToString(testArr8);
        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New Number: {i}, Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and print each value to the console. 
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The maxium number is {max}.");
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            float sum = 0;
            float avg = 0;
            foreach (float num in numbers)
            {
                sum += num;
            }
            avg = sum / numbers.Length;
            Console.WriteLine($"The average for this array is {avg}.");
        }
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            ArrayList oddNumbers = new ArrayList();
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            foreach (int num in oddNumbers)
            {
                Console.WriteLine($"{num}");
            };
            int[] newArr = oddNumbers.ToArray().Clone() as int[];
            return newArr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    count++;
                }
            }
            Console.Write("The current Array is: ");
            Console.WriteLine(String.Join(",", numbers));
            Console.WriteLine($"The number of integers greater than {y} is {count}.");
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            int i = 0;
            while (i < numbers.Length)
            {
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
                i++;
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            float avg = 0;
            foreach (int num in numbers)
            {
                if (min < num)
                {
                    min = num;
                }
                if (max > num)
                {
                    max = num;
                }
                sum += num;
            }
            avg = (float)sum / (float)numbers.Length;
            Console.Write("The current Array is: ");
            Console.WriteLine(String.Join(", ", numbers));
            Console.WriteLine($"The Minimum is: {min}.\nThe Maximum is: {max}.\nThe sum is: {sum}.\nThe avg is: {avg}.");
        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            int i = 1;
            while (i < numbers.Length)
            {
                numbers[i - 1] = numbers[i];
                i++;
            }
            numbers[numbers.Length - 1] = 0;
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] arr = new object[numbers.Length];
            int i = 0;
            while (i < numbers.Length)
            {
                if (numbers[i] < 0)
                {
                    arr[i] = "Dojo";
                }
                else
                {
                    arr[i] = numbers[i];
                }
                i++;
            }
            foreach (var thing in arr)
            {
                Console.WriteLine(thing);
            }
            return arr;
        }
    }
}
