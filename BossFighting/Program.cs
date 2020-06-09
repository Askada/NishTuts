using System;

namespace BossFighting
{
    public enum Characterclass
    {
        Warrior=10,
        Hunter=15,
        Mage=20,
        Rogue=25,
        Priest=5
    }

    class Program
    {
        static void Main()
        {
            
            int bosshealth = 150;
            int bossmaxdamage = 40;
            int tankhealth = 50;
            int priesthealingpower = 15;
            
            Characterclass[] party = {Characterclass.Warrior, Characterclass.Rogue, Characterclass.Hunter, Characterclass.Mage, Characterclass.Priest };
            Console.WriteLine("Your party consist of:");
            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine($"{party[i]} {(int)party[i]} dmg" );
            }

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Boss has been engaged!!");

            while (bosshealth > 0 && tankhealth > 0)
            {
                Console.WriteLine();

                //faza bossa
                int bossdamage = CalculateBossdmg(bossmaxdamage);
                tankhealth = tankhealth - bossdamage;
                Console.WriteLine($"Boss has done {bossdamage} damage to Warrior.");
                Console.WriteLine($"Remaining Warrior health: {tankhealth}");

                //faza heala
                tankhealth = tankhealth + priesthealingpower;
                Console.WriteLine($"Priest heals warrior for {priesthealingpower}. Remaining Warrior health: {tankhealth}");

                Console.WriteLine();

                //faza dmg druzyny
                for (int i = 0; i < party.Length; i = i + 1)
                {
                    
                    int characterdamage = CalculatePartydmg((int)party[i]);
                    Console.WriteLine($"{party[i]} has done {characterdamage} damage.");

                    bosshealth = bosshealth - characterdamage;
                    Console.WriteLine($"Remaining boss health: {bosshealth}");

                }
            }

            //kto wygral
            Console.WriteLine();
            if (bosshealth > 0)
            {
                Console.WriteLine($"Boss wins! Stands still with {bosshealth} health.");
            }
            else if (tankhealth > 0)
            {
                Console.WriteLine($"Your party wins! Warrior has {tankhealth} health left.");
            }
            else
            {
                Console.WriteLine("Everyone dies. GFG.");
            }
        }

        static int CalculatePartydmg(int maxDamage)
        {
            int damage = new Random().Next(1, maxDamage+1);
            return damage;   
        }

        static int CalculateBossdmg(int maxDamage)
        {
            int damage = new Random().Next(10, maxDamage + 1);
            return damage;
        }
    }
}
