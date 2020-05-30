using System;

namespace NishTut3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Roll the dice against your Lethality!");

            int lethality = 1;
            int rollD6 = rollDice(7);
            int rollD18 = rollDice(19);
            int rollD24 = rollDice(25);
            

            
            Console.WriteLine($"Your lethality is {lethality}.");
            Console.WriteLine($"You have rolled {rollD6}!");

            
            if (rollD6 <= lethality)
            {
                Console.WriteLine("They die.");

            }
            else
            {
                Console.WriteLine("They live.");
                Console.WriteLine("Do you want to reroll? (y/n)");

                string yesorno = Console.ReadLine();

                while (yesorno != "y" && yesorno != "n")
                {
                    Console.WriteLine("Do you want to reroll you fucking faggot?");
                    yesorno = Console.ReadLine();
                }


                if (yesorno == "y")
                {
                    int rerollD6 = rollDice(7);
                    Console.WriteLine($"You have rolled {rerollD6}!");

                    if (rerollD6 <= lethality)
                    {
                        Console.WriteLine("They die.");
                    }
                    else
                    {
                        Console.WriteLine("They live.");
                    }

                }
                else if (yesorno == "n")
                {
                    Console.WriteLine("Try again next time.");
                }

               


            }


        }

        static int rollTheDeathDice()
        {
            int deathroll = new Random().Next(1, 7);
            return deathroll;

        }

        static int rollDice(int dicetype)
        {
            int roll = new Random().Next(1, dicetype);
            return roll;

        }
    }
}
