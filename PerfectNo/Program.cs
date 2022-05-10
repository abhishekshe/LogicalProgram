using System;

namespace LogicalPrograms
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int number, n;
            int sum = 0;

           
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;

            Console.WriteLine("The Divisors for the number {0} are", number);

            for (int divisor = 1; divisor < number; divisor++)
            {
                if ((number % divisor) == 0)
                {
                    Console.Write("{0} ", divisor);

                    sum += divisor;
                }
            }

            
            if (sum == n)
            {
                Console.WriteLine("\nEntered number is perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nEntered number is not perfect number");
                Console.ReadLine();
            }
        }
    }
}