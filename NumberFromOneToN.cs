using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumberFromOneToN
{
    class NumberFromOneToN
    {
        static void Main()
        {
            //Version 1
            int n = int.Parse(Console.ReadLine());
            int counter=1;

            while (counter<=n)
                {
                    Console.Write("{0} ", counter);
                    counter++;
                }

            Console.WriteLine();

            /* Version 2

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                {
                    Console.Write(i +' ');
                }
            Console.WriteLine();
            */

        }
    }
}
