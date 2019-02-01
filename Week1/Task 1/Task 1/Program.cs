using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
                Console.Write(a[i] + " " + a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
