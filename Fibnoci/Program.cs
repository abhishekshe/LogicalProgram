using System;

namespace LogicalPrograms
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0;
            int b = 1;
            int c;

           
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
          
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c);

             
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}