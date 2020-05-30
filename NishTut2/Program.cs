using System;

namespace NishTut2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lets play!");

            int hp = 100;
            int maxDAMAGE = 99;
            int dmgt = GetNonZeroRnd(maxDAMAGE);
            int heal = GetNonZeroRnd(50);
            float absorb = 0.3f;
            int dmgc = CalculateDmg(dmgt, absorb);

            int left = hp - dmgc + heal;


            Console.WriteLine($"Vrzasq has {hp} health.");
            Console.WriteLine($"Vrzasq has taken {dmgt} damage!");
            Console.WriteLine($"Vrzasq has done {heal} healing!");
            Console.WriteLine($"Vrzasq has {left} health left.");
            

                      
         }

        static int GetNonZeroRnd(int value)
        {
            
            return new Random().Next(value) + 1;
        }

        static int CalculateDmg(int dmgt, float absorb)
        {
            
            float dmgabsorbed = dmgt * absorb;
            float dmgfinal = dmgt - dmgabsorbed;

            Console.WriteLine($"{dmgabsorbed} damaged has been absorbed.");
            return (int)dmgfinal;

        }
    }
}
