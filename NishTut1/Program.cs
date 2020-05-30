using System;

namespace NishTut1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Let's Play.");

            int damage1 = 10;
            int heal1 = 5;

            int @int = default;
            byte @byte = default;
            char @char = default;
            float @float = default;
            double @double = default;
            decimal @decimal = default;
            bool @bool = default;
                       

            Console.WriteLine("Vrzasq has taken:{0} damage", damage1);
            Console.WriteLine($"Vrzasq has done:{heal1} heal");

            Console.WriteLine($"Default int is: {@int}");
            Console.WriteLine($"Default byte is: {@byte}");
            Console.WriteLine($"Default char is: {@char}");
            Console.WriteLine($"Default float is: {@float}");
            Console.WriteLine($"Default double is: {@double}");
            Console.WriteLine($"Default decimal is: {@decimal}");
            Console.WriteLine($"Default bool is: {@bool}");
        }


    }
}
