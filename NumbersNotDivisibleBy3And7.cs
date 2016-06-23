﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

           // Version 2
            //    for (int i=1; i<=n; i++)
            //{
            //    if(i%3==0 || i%7==0)
            //    {
            //        continue;
            //    }
            //    Console.Write("{0} ", i);
            //}
            
        }
    }
}
