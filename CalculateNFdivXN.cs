using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateNFdivXN
{
    class CalculateNFdivXN
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + (fact / Math.Pow(x, i));
            }
            Console.WriteLine("s= {0:F5}", sum);

            /*
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double factorielN = 1;
            double sum = 1 + 1 / x;
            for (double i = 2; i <= n; i++)
            {
                factorielN *= i;
                sum += factorielN / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
             */

        }
    }
}
