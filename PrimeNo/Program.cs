using System;

namespace LogicalPrograms
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            int flag = 0;

          
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number {0} is not a prime number", num);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number {0} is  a prime number", num);
            }
            Console.ReadLine();

        }
    }
}