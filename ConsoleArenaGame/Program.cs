using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System;
using System.Collections.Generic;

namespace ConsoleArenaGame
{
    class Program
    {

        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }

        static void Main(string[] args)
        {
            Hero heroA = new Witch("Witch", 10, 20);
            Hero heroB = new Assassin("Asassin", 10, 5);

            GameEngine gameEngine = new GameEngine
            {
                HeroA = heroA,
                HeroB = heroB,
                NotificationsCallBack = ConsoleNotification
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}
