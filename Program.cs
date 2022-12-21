using System;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for two numbers
            Console.Write("Please enter the first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());

            // Print the list of perfect numbers
            Console.WriteLine("Perfect numbers between {0} and {1} are: ", n1, n2);

            // Create a loop to iterate from n1 to n2
            for (int i = n1; i <= n2; i++)
            {
                int count = 0;

                // Create a loop to check if the number is prime
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                // If the number is prime, print i
                if (count == 0 && i != 1)
                {
                    Console.WriteLine(i + " ");
                    Console.WriteLine("*****");
                }
            }
        }
    }
}

