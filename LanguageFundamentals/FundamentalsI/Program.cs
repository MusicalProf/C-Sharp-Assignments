using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5 but not both.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Unable to print number");
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            // Print all values from 1-255
            int j = 1;
            int k = 1;
            int l = 1;
            while (j <= 255)
            {
                Console.WriteLine(j);
                j++;
            }
            // Print all values 1-100 that are divisible by 3 or 5 but not both.
            while (k <= 100)
            {
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("Unable to print number");
                    k++;
                }
                else if (k % 3 == 0 || k % 5 == 0)
                {
                    Console.WriteLine(k);
                    k++;
                }
                k++;
            }
            // Print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for multiples of both 3 and 5. 
            while(l <= 100){
                if(l%3 == 0 && l%5 == 0){
                    Console.WriteLine("FizzBuzz");
                    l++;
                }else if(l%5 ==0){
                    Console.WriteLine("Fizz");
                    l++;
                }else if(l%3 == 0){
                    Console.WriteLine("Buzz");
                    l++;
                }
                l++;
            }
        }
    }
}
