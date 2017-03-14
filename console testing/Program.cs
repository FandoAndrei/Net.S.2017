using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int[] a = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n1; i++)
            {
                Console.Write("    " + a[i]);
            }
            Console.WriteLine();
            Console.ReadKey();

            SortMethods.MergingSortMethod.MergingMethod(a);

            Console.WriteLine();

            for (int i = 0; i < n1; i++)
                Console.WriteLine("   " + a[i]);
            Console.ReadKey();

        }
    }
}
