using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] faces ={"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
       
            for (int row = 0; row < faces.Length; row++)
                {            
                    for (int column = 0; column < 4; column++)
                    {
                        switch(column)
                        {
                            case 0: Console.Write(faces[row] + '\u2663' + '\t'); break;
                            case 1: Console.Write (faces[row] + '\u2666' + '\t'); break;
                            case 2: Console.Write(faces[row] + '\u2665' + '\t'); break;
                            case 3: Console.Write(faces[row] + '\u2660' + '\t'); break;
                         }
                    }
                    Console.WriteLine();
                 }

           /*
            {
                Console.Write(faces[i] + '\u2663' + "\t" + faces[i] + '\u2666' + "\t"
                    + faces[i] + '\u2665' + "\t" + faces[i] + '\u2660');
                Console.WriteLine();
            }
            */

            /* Version 2
                  char heart = '\u2665';
            char diamond = '\u2666';
            char spade = '\u2660';
            char club = '\u2663';

            for (int i = 2; i < 14; i++ )
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, heart, diamond, club, spade); break;
                    case 11: Console.WriteLine("J{1} J{2} J{3} J{4}", i, heart, diamond, club, spade); break;
                    case 12: Console.WriteLine("Q{1} Q{2} Q{3} Q{4}", i, heart, diamond, club, spade); break;
                    case 13: Console.WriteLine("K{1} K{2} K{3} K{4}", i, heart, diamond, club, spade); break;
                    case 14: Console.WriteLine("A{1} A{2} A{3} A{4}", i, heart, diamond, club, spade); break;
                }

            }
                Console.WriteLine();
             */
        }
    }
}
