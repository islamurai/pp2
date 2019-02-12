using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            string[] arr = Console.ReadLine().Split();
            for(int i= 0;i< a;i++)
            {
                int b = int.Parse(arr[i]);
                int ok = 1;
                for (int j = 2; j <= (int)Math.Sqrt(a) && ok == 1; j++)
                    if (b % j == 0)
                        ok = 0;
                if (b != 1 && ok == 1)
                    ans.Add(b);

            } Console.WriteLine(ans.Count());
            for (int i = 0; i < ans.Count(); i++)
                Console.Write(ans[i] + " ");
            Console.ReadKey();

        }
    }
}
