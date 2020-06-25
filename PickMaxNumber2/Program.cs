using System;

namespace PickMaxNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] loottable = GenerateRandomTable(10);
            int max = PickMax(loottable);
            Console.WriteLine($"Max is {max}");
        }


        static int PickMax(int[] randomelements)
        {
            int max2 = randomelements[0];
            for (int i = 1; i < randomelements.Length; i++)
            {
                if (max2 < randomelements[i])
                {
                    max2 = randomelements[i];
                }

            }
            return max2;

        }

        static int[] GenerateRandomTable(int count)
        {
            int[] randomtable1 = new int[count];
            for (int i = 0; i < randomtable1.Length; i++)
            {
                randomtable1[i] = new Random().Next(5000);
                Console.WriteLine(randomtable1[i]);
            }
            return randomtable1;
        }

    }
}
