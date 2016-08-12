using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] lines= new int[n];
            int sum = 0;
            
            for(int i=0; i<n; i++)
            {
                lines[i] = int.Parse(Console.ReadLine());
                sum += lines[i];
            }

            int max = lines.Max();
            int min = lines.Min();
            double avg = lines.Average();

            Console.WriteLine("min = {0} ", min);
            Console.WriteLine("max = {0} ", max);
            Console.WriteLine("sum = {0} ", sum);
            Console.WriteLine("avg = {0:F2} ", avg);
            
            /*
              Version 2
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                  int currentNum=int.Parse(Console.ReadLine());
                  sum +=currentNum;
                
                
                if (min>currentNum)
                    {
                        min = currentNum;
                    }   
                if (max<currentNum)
                    {
                        max = currentNum;
                    }
            }

            Console.WriteLine("min = " + min );
            Console.WriteLine("max = " + max);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avg= {0:F2}", sum/num);

            /* Version 3
             
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();

            Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:F2}", min, max, sum, avg);
            */
        }

    }
}
