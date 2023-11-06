using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublenestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double Nested Loops: ");
            Console.WriteLine("(a loop within a loop!)");
            Console.WriteLine("------------------------");
            Console.WriteLine();


            // Counting 

            // int numDigits = 2; // binary counting
            // int numDigits = 3; // trinary 
            // int numDigits = 8; // octal
            // int numDigits = 10; // decimal
                                // int numDigits = 16; // hexadecimal



            // for (int i = 0; i <= numDigits - 1; i++) // i = 0...9
            // {
            //     for (int j = 0; j <= numDigits - 1; j++) // x = 0...9
            //     {
            //         for (int k = 0; k <= numDigits - 1; k++) // x = 0...9
            //         {
            //             Console.WriteLine(i + "" + j + "" + k);
            //         }
            //     }

            // }


            int width = 20;
            int height = 10;    
            
            for (int x = 0; x <= width - 1; x++) // i = 0...9
            {
                for (int y = 0; y <= height - 1; y++) // x = 0...9
                {
                    
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");   
                }
            }
                    
                       
                    



            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);


        }

        // static void InnerLoop(int i)
        // {
        //    for (int x = 0; x <= 9; x++) // x = 0...9
        //    {
        //        Console.WriteLine(i + " " + x);
        //    }
        // }

    }
}
