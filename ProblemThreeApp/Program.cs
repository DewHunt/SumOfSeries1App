using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Numbers are : ");
            Console.Write("\n\t");
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i+", ");
                    sum = sum + i;
                }
            }

            Console.WriteLine("\n\nThe Summation : " + sum);

            Console.ReadKey();
        }
    }
}
