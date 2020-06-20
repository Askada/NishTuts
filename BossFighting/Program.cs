using System;
using System.Collections.Generic;

namespace BossFighting
{
    public enum Characterclass
    {
        Warrior = 10,
        Hunter = 15,
        Mage = 20,
        Rogue = 25,
        Priest = 5
    }

    class Program
    {
        static void Main()
        {

            int bosshealth = 150;
            int bossmaxdamage = 40;
            int tankhealth = 50;
            int priesthealingpower = 15;

            Characterclass[] party = { Characterclass.Warrior, Characterclass.Rogue, Characterclass.Hunter, Characterclass.Mage, Characterclass.Priest };
            Console.WriteLine("Your party consist of:");
            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine($"{party[i]} {(int)party[i]} dmg");
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

            //drop jesli tank zyje
            Console.WriteLine();
            if (tankhealth > 0)
            {

                int axeDmg = new Random().Next(5, 13);
                int swordDmg = new Random().Next(4, 14);
                int spearDmg = new Random().Next(3, 15);
                Console.WriteLine("The boss has dropped following items, pick only one:");
                Console.WriteLine($"Axe: {axeDmg} damage points");
                Console.WriteLine($"Sword: {swordDmg} damage points");
                Console.WriteLine($"Spear: {spearDmg} damage points");
                Console.WriteLine();
                int bestweapon = Math.Max(Math.Max(axeDmg, swordDmg), spearDmg);
                if (axeDmg == bestweapon)
                {
                    Console.WriteLine($"Your party chooses the AXE.");
                }
                else if (swordDmg == bestweapon)
                {
                    Console.WriteLine($"Your party chooses the SWORD.");
                }
                else if (spearDmg == bestweapon)
                {
                    Console.WriteLine($"Your party chooses the SPEAR.");
                }

                // Console.WriteLine($"Your party chooses {nameof(bestweapon)} weapon with {bestweapon} damage points.");
                // Console.WriteLine(Convert.ToString(nameof(bestweapon)));


                // zmiana dropu?
                Console.WriteLine("Do you want to change the choosen weapon? (y/n)");

                string yesorno = Console.ReadLine();
                
                if (yesorno == "y")
                {
                    Console.WriteLine("Which one do you want?");

                    string weaponChange = Console.ReadLine();

                    if (weaponChange == "axe" || weaponChange == "Axe")
                    {
                        Console.WriteLine("You leave the dungeon with an axe.");
                    }
                    else if (weaponChange == "sword" || weaponChange == "Sword")
                    {
                        Console.WriteLine("You leave the dungeon with a sword.");
                    }
                    else if (weaponChange == "spear" || weaponChange == "Spear")
                    {
                        Console.WriteLine("You leave the dungeon with a spear.");
                    }

                }
                else if (yesorno == "n")
                {
                    Console.WriteLine("Good. Because that one was best.");
                }

               
            }
        }

        static int CalculatePartydmg(int maxDamage)
        {
            int damage = new Random().Next(1, maxDamage + 1);
            return damage;
        }

        static int CalculateBossdmg(int maxDamage)
        {
            int damage = new Random().Next(10, maxDamage + 1);
            return damage;
        }

    }
}  

