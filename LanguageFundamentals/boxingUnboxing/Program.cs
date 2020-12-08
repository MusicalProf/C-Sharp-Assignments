using System;
using System.Collections.Generic;
namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an empty list of objects
            List<object> variousObjs = new List<object>();
            // Add objects to the list
            variousObjs.Add(7);
            variousObjs.Add(28);
            variousObjs.Add(-1);
            variousObjs.Add(true);
            variousObjs.Add("chair");

            // Looping through an printing out each object
            foreach (var obj in variousObjs)
            {
                Console.WriteLine(obj);
            }
            sumAll(variousObjs);
        }
        // This method adds all of the values of int type together and outputs the sum. 
        static int sumAll(List<object> arr)
        {
            int sum = 0;
            foreach (object thing in arr)
            {
                if (thing is int)
                {
                    sum += (int)thing;
                }
                else
                {
                    Console.WriteLine(thing);
                }
            }
            Console.WriteLine($"The sum of all the integers is {sum}.");
            return sum;
        }
    }
}
