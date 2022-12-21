using System;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            // Input the two numbers
            Console.Write("Enter first number: ");

            int n1 = int.Parse(Console.ReadLine());
      
            Console.Write("Enter second number: ");

            int n2 = int.Parse(Console.ReadLine());

            // Print the list of perfect numbers
            Console.WriteLine("Perfect numbers between {0} and {1} are: ", n1, n2);


            // Create a loop to check if the number is perfect
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                
                if (sum == i)
                // If the number is perfect, print i
                {
                    Console.WriteLine("{0} ", i);
                    Console.WriteLine("*******");
                }
            }
        }
    }
}
    

