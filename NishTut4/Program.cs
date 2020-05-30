using System;

namespace NishTut4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            int[] ekwipunekjeden = new int[8];
            ekwipunekjeden[0] = 1675;
            Console.WriteLine(ekwipunekjeden[0]);
            int[] ekwipunekdwa = {11, 22, 33, 44, 55, 66, 77, 88, 99, 111};

            Console.WriteLine(ekwipunekdwa[0]);

            //zwroc mi wartosc zmiennej na miejscu o wartosci i
            //ekwipunekdwa[i];


            int i = 0;
            Console.WriteLine($"i value is {i}");
            while (i < 10)
            {
                Console.WriteLine($"You have {ekwipunekdwa[i]} in slot {i}");
                i = i + 1;

            }
            Console.WriteLine($"i value is {i}");

            int preinkrementacja = i++;
            Console.WriteLine(i);
            Console.WriteLine(preinkrementacja);

            for (int j = 0; j < ekwipunekdwa.Length; j++)
            {
                Console.WriteLine($"You have {ekwipunekdwa[j]} in slot {j}");
            }
        }
    }
}


