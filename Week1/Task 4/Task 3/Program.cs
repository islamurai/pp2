using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) 
            {
                for (int j = 0; j <= a; j++)
                {
                    if (i>=j)

                    {
                        Console.Write("[*]");

                    }
                    if (j==a)
                    {


                        Console.WriteLine();

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
