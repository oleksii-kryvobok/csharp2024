using System;
using System.Threading;

namespace MageBattle
{
    class Program
    {
        private static string[] elements = { "Anemo", "Hydro", "Cryo", "Dendro", "Pyro", "Electro", "Geo" };
        static void Main()
        {
            Console.Write("Enter your mage's name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Available elements:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {elements[i]}");
            }

            int elementIndex;
            while (true)
            {
                Console.Write("Enter the number of your chosen element (1-7): ");
                if (int.TryParse(Console.ReadLine(), out elementIndex) && elementIndex >= 1 && elementIndex <= 7)
                {
                    break;
                }
                Console.WriteLine("Invalid input, enter a number between 1 and 7.");
            }

            string playerElement = elements[elementIndex - 1];

            PlayerMage playerMage = new PlayerMage(playerName, playerElement);
            EnemyMage enemyMage = new EnemyMage("AbyssMage");

            Thread.Sleep(500);
            Console.WriteLine($"\nYour opponent is {enemyMage.Name}, element: {enemyMage.Element}");

            playerMage.OnAttack += (sender, e) => Console.WriteLine($"{((Mage)sender).Name} is attacking {e.Target.Name}!");
            playerMage.OnDefend += (sender, e) => Console.WriteLine($"{((Mage)sender).Name} defended and took {e.Damage} damage!");
            playerMage.OnDefeated += (sender, e) => Console.WriteLine($"\n{((Mage)sender).Name} has been defeated, you lose!");

            enemyMage.OnAttack += (sender, e) => Console.WriteLine($"{((Mage)sender).Name} is attacking {e.Target.Name}!");
            enemyMage.OnDefend += (sender, e) => Console.WriteLine($"{((Mage)sender).Name} defended and took {e.Damage} damage!");
            enemyMage.OnDefeated += (sender, e) => Console.WriteLine($"\n{((Mage)sender).Name} has been defeated, you win!");

            while (playerMage.IsAlive() && enemyMage.IsAlive())
            {
                Console.Write("\nAre you ready to attack? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    Thread.Sleep(500);
                    Console.WriteLine("\nYou are not ready. The enemy attacks!");
                    Thread.Sleep(2000);
                    enemyMage.Attack(playerMage);
                    if (!playerMage.IsAlive())
                    {
                        Thread.Sleep(500);
                        //Console.WriteLine($"\n{playerMage.Name} has been defeated! You lost.");
                        break;
                    }
                    continue;
                }

                playerMage.Attack(enemyMage);
                if (!enemyMage.IsAlive())
                {
                    Thread.Sleep(500);
                    //Console.WriteLine($"\n{enemyMage.Name} has been defeated! You won!");
                    break;
                }

                Thread.Sleep(2000);

                enemyMage.Attack(playerMage);
                if (!playerMage.IsAlive())
                {
                    Thread.Sleep(500);
                    //Console.WriteLine($"\n{playerMage.Name} has been defeated! You lost.");
                    break;
                }

                Thread.Sleep(2000);
            }
        }
    }
}