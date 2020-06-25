using System;
using System.Linq;

namespace PickMaxNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int[] loottable = {33, 31, 42, 8, 15, 64, 59, 44, 29};
            //int max = loottable.Max();
            //Console.WriteLine(max);
            int max = loottable[0];

           

            for (int i = 1; i < loottable.Length; i++)
            {
                if (max < loottable[i])
                {
                    max = loottable[i];
                }

            }

            Console.WriteLine($"Max is {max}");

        }

    }
}
